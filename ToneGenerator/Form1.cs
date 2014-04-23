using System;
using System.Collections.Generic;
using System.Reflection;
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
        const decimal FrequencyIncrement = 1.0594630943592952645618252949463m;
        const decimal HalfFrequencyIncrement = 1.0293022366434920287823718007739m;

        private WaveOut waveOut;
        private SineWaveProvider32 waveProvider = new SineWaveProvider32();

        private List<SoundtrackControl> soundtrackControls = new List<SoundtrackControl>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            waveOut = new WaveOut(Handle);
            waveOut.DesiredLatency = 100;
            waveOut.Init(waveProvider);
            waveOut.Volume = 1;

            soundtrackControls.Add(soundtrackControl1);
            soundtrackControls.Add(soundtrackControl2);
            foreach (var control in soundtrackControls)
            {
                waveProvider.Soundtracks.Add(control.Soundtrack);
            }
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
        private void playButton_CheckedChanged(object sender, EventArgs e)
        {
            StartStopSineWave();
        }

        private async void StartStopSineWave()
        {
            if (!waveProvider.IsPlaying)
            {
                waveProvider.Sample = 0;
                waveProvider.IsPlaying = true;
                if (waveOut.PlaybackState == PlaybackState.Stopped)
                    waveOut.Play();
            }
            else
            {
                waveProvider.InitiateStop();
                await Task.Delay(2 * waveOut.DesiredLatency + (int)(1000 * SineWaveProvider32.RAMP_DURATION));
                if (!waveProvider.IsPlaying)
                    waveOut.Stop();
            }
        }
    }
}
