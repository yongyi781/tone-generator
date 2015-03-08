using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace ToneGenerator
{
    /// <summary>
    /// The main form for the application.
    /// </summary>
    public partial class Form1 : Form
    {
        public const int DefaultLatency = 100;

        private WaveOut waveOut;
        private SineWaveProvider32 waveProvider = new SineWaveProvider32();

        private List<SoundtrackControl> soundtrackControls = new List<SoundtrackControl>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1(int desiredLatency = DefaultLatency)
        {
            InitializeComponent();

            waveOut = new WaveOut(Handle);
            waveOut.DesiredLatency = desiredLatency;
            waveOut.Init(waveProvider);
            waveOut.Volume = 1;

            for (int i = 0; i < 6; i++)
            {
                var control = new SoundtrackControl(i == 0);
                control.Dock = DockStyle.Top;
                soundtrackControls.Add(control);
                tableLayoutPanel.Controls.Add(control);
                waveProvider.Soundtracks.Add(control.Soundtrack);
            }
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
                case Keys.Enter:
                case Keys.Space:
                    playButton.Checked = !playButton.Checked;
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        /// <summary>
        /// Intercepts space and enter key presses.
        /// </summary>
        /// <param name="m">The message.</param>
        /// <returns>true if the keystroke was processed and consumed by the control; otherwise, false to allow further processing.</returns>
        protected override bool ProcessKeyPreview(ref Message m)
        {
            if (m.WParam == new IntPtr(13) || m.WParam == new IntPtr(32)) // Enter or space
                return true;
            return base.ProcessKeyPreview(ref m);
        }

        private async void StartStopSineWave()
        {
            if (!waveProvider.IsPlaying)
            {
                waveProvider.Sample = 0;
                waveProvider.IsPlaying = true;
                playButton.ForeColor = Color.Green;
                playButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
                if (waveOut.PlaybackState == PlaybackState.Stopped)
                    waveOut.Play();
            }
            else
            {
                waveProvider.InitiateStop();
                playButton.ForeColor = DefaultForeColor;
                playButton.FlatAppearance.MouseOverBackColor = DefaultBackColor;
                // Allow time to ramp out.
                await Task.Delay(2 * waveOut.DesiredLatency + (int)(1000 * SineWaveProvider32.RAMP_DURATION));
                if (!waveProvider.IsPlaying)
                    waveOut.Stop();
            }
        }

        private void playButton_CheckedChanged(object sender, EventArgs e)
        {
            StartStopSineWave();
        }

        private void masterVolumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            waveOut.Volume = masterVolumeSlider.Volume;
        }

        private void minimumVolumeUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var soundtrackControl in soundtrackControls)
                soundtrackControl.SetMinimumVolume((float)minimumVolumeUpDown.Value);
            masterVolumeSlider.MinimumDB = (float)minimumVolumeUpDown.Value;
        }
    }
}
