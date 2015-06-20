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
        private Binding freqBinding;
        private Binding ampBinding;

        [CLSCompliant(false)]
        public SineWaveProvider CurrentWaveProvider { get; set; }
        public Calibration CurrentCalibration => CurrentWaveProvider.Calibration;

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
            
            // Binding
            freqBinding = new Binding("Text", this, "CurrentCalibration.Frequencies");
            ampBinding = new Binding("Text", this, "CurrentCalibration.Amplitudes");
            freqBinding.Format += ListJsonBinding_Format;
            ampBinding.Format += ListJsonBinding_Format;
            freqBinding.Parse += ListJsonBinding_Parse;
            ampBinding.Parse += ListJsonBinding_Parse;
            calibrateFreqsTextBox.DataBindings.Add(freqBinding);
            calibrateAmpsTextBox.DataBindings.Add(ampBinding);

            modeComboBox.SelectedIndex = 0;
        }

        private void ListJsonBinding_Parse(object sender, ConvertEventArgs e)
        {
            e.Value = JsonConvert.DeserializeObject((string)e.Value, e.DesiredType);
            if (sender == freqBinding)
            {
                // Sort and remove duplicates
                var freqs = (ICollection<float>)e.Value;
                e.Value = freqs.Distinct().OrderBy(f => f).ToList();
            }

            // Make sure Amplitudes is the same length as Frequencies
            int frequenciesCount = sender == freqBinding ? ((ICollection<float>)e.Value).Count : CurrentCalibration.Frequencies.Count;
            var currentAmps = sender == ampBinding ? (List<float>)e.Value : CurrentCalibration.Amplitudes;
            int sizeDiff = frequenciesCount - currentAmps.Count;
            if (sizeDiff != 0)
            {
                if (sizeDiff > 0)
                    currentAmps.AddRange(Enumerable.Repeat(0f, sizeDiff));
                else if (sizeDiff < 0)
                    currentAmps.RemoveRange(frequenciesCount, -sizeDiff);
                ampBinding.ReadValue();
            }
        }

        private void ListJsonBinding_Format(object sender, ConvertEventArgs e)
        {
            e.Value = JsonConvert.SerializeObject(e.Value);
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
            freqBinding.ReadValue();
            ampBinding.ReadValue();
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

        private void calibrateSaveButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                FileName = "calibration.json",
                InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Calibration"),
                Filter = "JSON Files|*.json|All Files|*.*"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var str = JsonConvert.SerializeObject(CurrentWaveProvider.Calibration, Formatting.Indented);
                    File.WriteAllText(sfd.FileName, str);
                }
            }
        }

        private void calibrateLoadButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Calibration"),
                Filter = "JSON Files|*.json|All Files|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CurrentWaveProvider.Calibration = JsonConvert.DeserializeObject<Calibration>(File.ReadAllText(ofd.FileName));
                    freqBinding.ReadValue();
                    ampBinding.ReadValue();
                }
            }
        }
    }
}
