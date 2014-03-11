using System;
using System.Reflection;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            frequencyNumeric.Maximum = waveProvider.WaveFormat.SampleRate / 2;
            waveProvider.Frequency = (float)frequencyNumeric.Value;
            var doubleBufferPropertyInfo = dBVolumeSlider.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferPropertyInfo.SetValue(dBVolumeSlider, true, null);

            minusButton.Tag = 1m / HalfFrequencyIncrement;
            plusButton.Tag = HalfFrequencyIncrement;
            prevNoteButton.Tag = 1m / FrequencyIncrement;
            nextNoteButton.Tag = FrequencyIncrement;
            prevOctaveButton.Tag = 0.5m;
            nextOctaveButton.Tag = 2m;
        }

        /// <summary>
        /// Processes shortcut keys for frequency and volume controls.
        /// </summary>
        /// <param name="msg">A <see cref="Message"/>, passed by reference, that represents the Win32 message to process.</param>
        /// <param name="keyData">One of the <see cref="Keys"/> values that represents the key to process.</param>
        /// <returns>true if the keystroke was processed and consumed by the control; otherwise, false to allow further processing.</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Add || keyData == Keys.Subtract)
            {
                // Change dbVolume by ±1 dB.
                double logVolume = Math.Log10(dBVolumeSlider.Volume);
                if (keyData == Keys.Subtract)
                    logVolume -= 0.05f;
                else if (keyData == Keys.Add)
                    logVolume += 0.05f;
                SetVolume((float)Math.Pow(10, logVolume));
                return true;
            }

            switch (keyData)
            {
                case Keys.OemMinus:
                    MultiplyFrequency(1m / HalfFrequencyIncrement);
                    return true;
                case Keys.Oemplus:
                    MultiplyFrequency(HalfFrequencyIncrement);
                    return true;
                case Keys.Oemcomma:
                    MultiplyFrequency(1m / FrequencyIncrement);
                    return true;
                case Keys.OemPeriod:
                    MultiplyFrequency(FrequencyIncrement);
                    return true;
                case Keys.OemOpenBrackets:
                    MultiplyFrequency(0.5m);
                    return true;
                case Keys.OemCloseBrackets:
                    MultiplyFrequency(2m);
                    return true;
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

        private void StartStopSineWave()
        {
            if (waveOut == null || waveOut.PlaybackState == PlaybackState.Stopped)
            {
                waveOut = new WaveOut(Handle);
                waveOut.Volume = (float)linearVolumeSlider.Value / linearVolumeSlider.Maximum;
                waveOut.Init(waveProvider);
                waveOut.DesiredLatency = 0;
                waveOut.Play();
                leftCheckBox.Enabled = rightCheckBox.Enabled = false;
            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
                leftCheckBox.Enabled = rightCheckBox.Enabled = true;
            }
        }

        private void SetVolume(float volume)
        {
            if (waveOut != null)
                waveOut.Volume = volume;
            volumeLabel.Text = "Volume: " + volume;
            linearVolumeSlider.Value = (int)(volume * linearVolumeSlider.Maximum);
            dBVolumeSlider.Volume = volume;
        }

        private void linearVolumeSlider_Scroll(object sender, EventArgs e)
        {
            SetVolume((float)linearVolumeSlider.Value / linearVolumeSlider.Maximum);
        }

        private void dBVolumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            SetVolume(dBVolumeSlider.Volume);
        }

        private void dBVolumeSlider_Resize(object sender, EventArgs e)
        {
            dBVolumeSlider.Invalidate();
        }

        private void frequencyNumeric_ValueChanged(object sender, EventArgs e)
        {
            waveProvider.Frequency = (float)frequencyNumeric.Value;
        }

        private void MultiplyFrequency(decimal factor)
        {
            var value = frequencyNumeric.Value * factor;
            if (value < frequencyNumeric.Minimum)
                value = frequencyNumeric.Minimum;
            if (value > frequencyNumeric.Maximum)
                value = frequencyNumeric.Maximum;
            frequencyNumeric.Value = value;
        }

        private void changeFrequencyButtons_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            MultiplyFrequency((decimal)btn.Tag);
        }

        private void leftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            waveProvider.PlayLeftChannel = leftCheckBox.Checked;
            if (!leftCheckBox.Checked && !rightCheckBox.Checked)
                rightCheckBox.Checked = true;
        }

        private void rightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            waveProvider.PlayRightChannel = rightCheckBox.Checked;
            if (!leftCheckBox.Checked && !rightCheckBox.Checked)
                leftCheckBox.Checked = true;
        }
    }
}
