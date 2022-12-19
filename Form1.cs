using NAudio.Wave;
using Newtonsoft.Json;

namespace ToneGenerator
{
	/// <summary>
	/// The main form for the application.
	/// </summary>
	public partial class Form1 : Form
	{
		public const int DefaultLatency = 128;
		public const int NumSoundtracks = 6;
		public const float DefaultAmplitude = 0.01f;

		private readonly WaveOut waveOut;
		private readonly SineWaveProvider sineWaveProvider;
		private readonly AlternatingWaveProvider alternatingWaveProvider;

		private readonly List<SoundtrackControl> soundtrackControls = new();

		public SineWaveProvider? CurrentWaveProvider { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Form1"/> class.
		/// </summary>
		public Form1(int desiredLatency = DefaultLatency)
		{
			InitializeComponent();
			waveOut = new WaveOut(Handle)
			{
				DesiredLatency = desiredLatency,
				Volume = 1
			};
			sineWaveProvider = new SineWaveProvider();
			alternatingWaveProvider = new AlternatingWaveProvider((double)periodUpDown.Value / 1000);

			for (int i = 0; i < NumSoundtracks; i++)
			{
				var control = new SoundtrackControl(i == 0)
				{
					Amplitude = Utilities.DbToMag(-40),
					Dock = DockStyle.Top
				};
				soundtrackControls.Add(control);
				tableLayoutPanel.Controls.Add(control);
				sineWaveProvider.Soundtracks.Add(control.Soundtrack);
				alternatingWaveProvider.Soundtracks.Add(control.Soundtrack);
			}

			modeComboBox.SelectedIndex = 0;
			//LoadCalibration(sineWaveProvider, Ear.Left, "Calibration/leftEarHearingLoss.json");
			//LoadCalibration(sineWaveProvider, Ear.Right, "Calibration/rightEarHearingLoss.json");
			//LoadCalibration(alternatingWaveProvider, Ear.Left, "Calibration/leftEarHearingLoss.json");
			//LoadCalibration(alternatingWaveProvider, Ear.Right, "Calibration/rightEarHearingLoss.json");

			// Use loudness by default
			//useLoudnessCheckBox.Checked = true;
			//maxVolumeUpDown.Value = 120;
		}

		public double FrequencyIncrement
		{
			get { return Math.Pow(2.0, 1.0 / (double)divisionTonesUpDown.Value); }
		}

		/// <summary>
		/// Processes shortcut keys for frequency and volume controls.
		/// </summary>
		/// <param name="msg">A <see cref="Message"/>, passed by reference, that represents the Win32 message to process.</param>
		/// <param name="keyData">One of the <see cref="Keys"/> values that represents the key to process.</param>
		/// <returns>true if the keystroke was processed and consumed by the control; otherwise, false to allow further processing.</returns>
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Space:
					if (calibrationPanel.Visible)
						return base.ProcessCmdKey(ref msg, keyData);
					playButton.Checked = !playButton.Checked;
					return true;
				default:
					return base.ProcessCmdKey(ref msg, keyData);
			}
		}

		/// <summary>
		/// Intercepts space key presses, to prevent buttons from being pressed.
		/// </summary>
		/// <param name="m">The message.</param>
		/// <returns>true if the keystroke was processed and consumed by the control; otherwise, false to allow further processing.</returns>
		protected override bool ProcessKeyPreview(ref Message m)
		{
			if (m.WParam == new IntPtr(32) && !calibrationPanel.Visible) // Space
				return true;
			return base.ProcessKeyPreview(ref m);
		}

		private async void StartStopSineWave(bool play)
		{
			if (CurrentWaveProvider == null)
				throw new InvalidOperationException("CurrentWaveProvider is null.");
			if (play)
			{
				CurrentWaveProvider.Sample = 0;
				CurrentWaveProvider.IsPlaying = true;
				playButton.ForeColor = Color.Green;
				playButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
				if (waveOut.PlaybackState == PlaybackState.Stopped)
					waveOut.Play();
			}
			else
			{
				CurrentWaveProvider.InitiateStop();
				playButton.ForeColor = DefaultForeColor;
				playButton.FlatAppearance.MouseOverBackColor = DefaultBackColor;
				// Allow time to ramp out.
				await Task.Delay(2 * waveOut.DesiredLatency + (int)(1000 * SineWaveProvider.RAMP_DURATION));
				if (!CurrentWaveProvider.IsPlaying)
					waveOut.Stop();
			}
		}

		private void SetWaveProvider(SineWaveProvider waveProvider)
		{
			if (CurrentWaveProvider != null && CurrentWaveProvider.IsPlaying)
			{
				StartStopSineWave(false);
				playButton.Checked = false;
			}

			CurrentWaveProvider = waveProvider;
			waveOut.Init(waveProvider);
		}

		private void LoadCalibration(SineWaveProvider waveProvider, Ear ear, string fileName)
		{
			(ear == Ear.Left ? calibrationLeftTextBox : calibrationRightTextBox).Text = fileName;
			Calibration? newCalibration;
			try
			{
				newCalibration = JsonConvert.DeserializeObject<Calibration>(File.ReadAllText(fileName));
			}
			catch (JsonSerializationException ex)
			{
				MessageBox.Show("Calibration file is invalid. Message: " + ex.Message);
				return;
			}
			if (newCalibration != null)
			{
				if (ear == Ear.Left)
					waveProvider.LeftCalibration = newCalibration;
				else
					waveProvider.RightCalibration = newCalibration;
			}
		}

		private void PlayButton_CheckedChanged(object sender, EventArgs e)
		{
			StartStopSineWave(playButton.Checked);
		}

		private void MasterVolumeSlider_VolumeChanged(object sender, EventArgs e)
		{
			waveOut.Volume = masterVolumeSlider.Volume;
		}

		private void MinMaxVolumeUpDown_ValueChanged(object sender, EventArgs e)
		{
			foreach (var soundtrackControl in soundtrackControls)
			{
				soundtrackControl.SetMinimumVolume((float)minVolumeUpDown.Value);
				soundtrackControl.SetMaximumValue((float)maxVolumeUpDown.Value);
			}
		}

		private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (modeComboBox.SelectedIndex)
			{
				case 0:
					SetWaveProvider(sineWaveProvider);
					break;
				case 1:
					SetWaveProvider(alternatingWaveProvider);
					periodLabel.Visible = periodUpDown.Visible = true;
					break;
				default:
					break;
			}
			periodLabel.Visible = periodUpDown.Visible = dutyCycleLabel.Visible = dutyCycleUpDown.Visible = modeComboBox.SelectedIndex == 1;
		}

		private void PeriodUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (alternatingWaveProvider != null)
				alternatingWaveProvider.Period = (double)periodUpDown.Value / 1000;
		}

		private void CalibrateButton_CheckedChanged(object sender, EventArgs e)
		{
			calibrationPanel.Visible = calibrateButton.Checked;
		}

		private void CalibrateBrowseButton_Click(object sender, EventArgs e)
		{
			var ear = sender == calibrateLeftBrowseButton ? Ear.Left : Ear.Right;
			using var ofd = new OpenFileDialog
			{
				InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Calibration"),
				Filter = "JSON Files|*.json|All Files|*.*"
			};
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				LoadCalibration(sineWaveProvider, ear, ofd.FileName);
				LoadCalibration(alternatingWaveProvider, ear, ofd.FileName);
			}
		}

		private void UseLoudnessCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			sineWaveProvider.UseLoudnessInCalibration = alternatingWaveProvider.UseLoudnessInCalibration = useLoudnessCheckBox.Checked;
		}

		private void ChangeFrequencyButtons_Click(object sender, EventArgs e)
		{
			var factor = 1.0;
			if (sender == minusButton)
				factor = 1.0 / Math.Sqrt(FrequencyIncrement);
			else if (sender == plusButton)
				factor = Math.Sqrt(FrequencyIncrement);
			else if (sender == prevNoteButton)
				factor = 1.0 / FrequencyIncrement;
			else if (sender == nextNoteButton)
				factor = FrequencyIncrement;
			else if (sender == prevOctaveButton)
				factor = 0.5;
			else if (sender == nextOctaveButton)
				factor = 2.0;

			foreach (var control in soundtrackControls)
				control.MultiplyFrequency(factor);
		}

		private void ResetCalibrationButton_Click(object sender, EventArgs e)
		{
			LoadCalibration(sineWaveProvider, Ear.Left, "calibration/none.json");
			LoadCalibration(sineWaveProvider, Ear.Right, "calibration/none.json");
			LoadCalibration(alternatingWaveProvider, Ear.Left, "calibration/none.json");
			LoadCalibration(alternatingWaveProvider, Ear.Right, "calibration/none.json");
			maxVolumeUpDown.Value = 0;
			minVolumeUpDown.Value = -60;
			useLoudnessCheckBox.Checked = false;
			foreach (var st in soundtrackControls)
			{
				st.Amplitude = Math.Min(st.Amplitude, DefaultAmplitude);
			}
		}

		private void DutyCycleUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (alternatingWaveProvider != null)
				alternatingWaveProvider.DutyCycle = (double)dutyCycleUpDown.Value;
		}
	}

	public enum Ear { Left, Right }
}
