using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace ToneGenerator
{
    /// <summary>
    /// The main form for the application.
    /// </summary>
    public partial class Form1 : Form
    {
        public const int DefaultLatency = 100;
        public const int NumSoundtracks = 6;

        private WaveOut waveOut;
        private SineWaveProvider sineWaveProvider;
        private AlternatingWaveProvider alternatingWaveProvider;

        private List<SoundtrackControl> soundtrackControls = new List<SoundtrackControl>();

        [CLSCompliant(false)]
        public SineWaveProvider CurrentWaveProvider { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1(int desiredLatency = DefaultLatency)
        {
            InitializeComponent();
            waveOut = new WaveOut(Handle);
            waveOut.DesiredLatency = desiredLatency;
            waveOut.Volume = 1;
            sineWaveProvider = new SineWaveProvider();
            alternatingWaveProvider = new AlternatingWaveProvider((double)periodUpDown.Value / 1000);

            for (int i = 0; i < NumSoundtracks; i++)
            {
                var control = new SoundtrackControl(i == 0);
                control.Dock = DockStyle.Top;
                soundtrackControls.Add(control);
                tableLayoutPanel.Controls.Add(control);
                sineWaveProvider.Soundtracks.Add(control.Soundtrack);
                alternatingWaveProvider.Soundtracks.Add(control.Soundtrack);
            }
            
            modeComboBox.SelectedIndex = 0;
            LoadCalibration(sineWaveProvider, Ear.Left, "Calibration/leftEarHearingLoss.json");
            LoadCalibration(sineWaveProvider, Ear.Right, "Calibration/rightEarHearingLoss.json");
            LoadCalibration(alternatingWaveProvider, Ear.Left, "Calibration/leftEarHearingLoss.json");
            LoadCalibration(alternatingWaveProvider, Ear.Right, "Calibration/rightEarHearingLoss.json");

            // Use loudness by default
            useLoudnessCheckBox.Checked = true;
            maxVolumeUpDown.Value = 120;
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
            Calibration newCalibration;
            try
            {
                newCalibration = JsonConvert.DeserializeObject<Calibration>(File.ReadAllText(fileName));
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show("Calibration file is invalid. Message: " + ex.Message);
                return;
            }
            if (ear == Ear.Left)
                waveProvider.LeftCalibration = newCalibration;
            else
                waveProvider.RightCalibration = newCalibration;
        }

        private void playButton_CheckedChanged(object sender, EventArgs e)
        {
            StartStopSineWave(playButton.Checked);
        }

        private void masterVolumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            waveOut.Volume = masterVolumeSlider.Volume;
        }

        private void minMaxVolumeUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var soundtrackControl in soundtrackControls)
            {
                soundtrackControl.SetMinimumVolume((float)minVolumeUpDown.Value);
                soundtrackControl.SetMaximumValue((float)maxVolumeUpDown.Value);
            }
            masterVolumeSlider.MinimumDB = (float)minVolumeUpDown.Value;
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeComboBox.SelectedIndex)
            {
                case 0:
                    SetWaveProvider(sineWaveProvider);
                    periodLabel.Visible = periodUpDown.Visible = false;
                    break;
                case 1:
                    SetWaveProvider(alternatingWaveProvider);
                    periodLabel.Visible = periodUpDown.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void periodUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (alternatingWaveProvider != null)
                alternatingWaveProvider.Period = (double)periodUpDown.Value / 1000;
        }

        private void calibrateButton_CheckedChanged(object sender, EventArgs e)
        {
            calibrationPanel.Visible = calibrateButton.Checked;
        }

        private void calibrateBrowseButton_Click(object sender, EventArgs e)
        {
            var ear = sender == calibrateLeftBrowseButton ? Ear.Left : Ear.Right;
            using (var ofd = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Calibration"),
                Filter = "JSON Files|*.json|All Files|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadCalibration(sineWaveProvider, ear, ofd.FileName);
                    LoadCalibration(alternatingWaveProvider, ear, ofd.FileName);
                }
            }
        }

        private void useLoudnessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sineWaveProvider.UseLoudnessInCalibration = alternatingWaveProvider.UseLoudnessInCalibration = useLoudnessCheckBox.Checked;
        }

        private void changeFrequencyButtons_Click(object sender, EventArgs e)
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
    }

    public enum Ear { Left, Right }
}
