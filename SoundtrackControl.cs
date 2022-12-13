using System;
using System.Windows.Forms;

namespace ToneGenerator
{
    public partial class SoundtrackControl : UserControl
    {
        public SoundtrackControl() : this(true) { }

        public SoundtrackControl(bool play)
        {
            InitializeComponent();

            frequencyNumeric.Maximum = SineWaveProvider.SAMPLE_RATE / 2M;

            Amplitude = 1f;
            Soundtrack.Frequency = (float)frequencyNumeric.Value;
            Soundtrack.Left = leftCheckBox.Checked = play;
            Soundtrack.Right = rightCheckBox.Checked = play;
        }

        public Soundtrack Soundtrack { get; private set; } = new Soundtrack();

        public float Amplitude
        {
            get => Soundtrack.Amplitude;
            set
            {
                if (value < 0.0f)
                    value = 0.0f;
                if (value != Amplitude)
                {
                    volumeLabel.Text = "Amplitude: " + value;
                    Soundtrack.Amplitude = value;
                    dBVolumeSlider.Volume = value;
                }
            }
        }

        public void SetMinimumVolume(float minVolume)
        {
            dBVolumeSlider.MinimumDB = minVolume;
        }

        internal void SetMaximumValue(float maxVolume)
        {
            dBVolumeSlider.MaximumDB = maxVolume;
        }
        
        public void SetLeft(bool value)
        {
            Soundtrack.Left = leftCheckBox.Checked = value;
        }

        public void SetRight(bool value)
        {
            Soundtrack.Right = rightCheckBox.Checked = value;
        }

        public void MultiplyFrequency(double factor)
        {
            var value = frequencyNumeric.Value * (decimal)factor;
            if (value < frequencyNumeric.Minimum)
                value = frequencyNumeric.Minimum;
            if (value > frequencyNumeric.Maximum)
                value = frequencyNumeric.Maximum;
            frequencyNumeric.Value = value;
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
                Amplitude = (float)Math.Pow(10, logVolume);
                return true;
            }

            switch (keyData)
            {
                case Keys.OemMinus:
                    MultiplyFrequency(1.0 / GetHalfFrequencyIncrement());
                    return true;
                case Keys.Oemplus:
                    MultiplyFrequency(GetHalfFrequencyIncrement());
                    return true;
                case Keys.Oemcomma:
                    MultiplyFrequency(1.0 / GetFrequencyIncrement());
                    return true;
                case Keys.OemPeriod:
                    MultiplyFrequency(GetFrequencyIncrement());
                    return true;
                case Keys.OemSemicolon:
                    MultiplyFrequency(1.0 / GetDoubleFrequencyIncrement());
                    return true;
                case Keys.OemQuotes:
                    MultiplyFrequency(GetDoubleFrequencyIncrement());
                    return true;
                case Keys.OemOpenBrackets:
                    MultiplyFrequency(0.5);
                    return true;
                case Keys.OemCloseBrackets:
                    MultiplyFrequency(2);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

        }

        private double GetFrequencyIncrement()
        {
            return ParentForm is not Form1 parent ? Math.Pow(2.0, 1.0 / 12) : parent.FrequencyIncrement;
        }

        private double GetDoubleFrequencyIncrement()
        {
            var x= GetFrequencyIncrement();
            return x * x;
        }

        private double GetHalfFrequencyIncrement()
        {
            return Math.Sqrt(GetFrequencyIncrement());
        }

        private void dBVolumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            Amplitude = dBVolumeSlider.Volume;
        }

        private void frequencyNumeric_ValueChanged(object sender, EventArgs e)
        {
            Soundtrack.Frequency = (float)frequencyNumeric.Value;
        }

        private void changeFrequencyButtons_Click(object sender, EventArgs e)
        {
            if (sender == minusButton)
                MultiplyFrequency(1.0 / GetHalfFrequencyIncrement());
            else if (sender == plusButton)
                MultiplyFrequency(GetHalfFrequencyIncrement());
            else if (sender == prevNoteButton)
                MultiplyFrequency(1.0 / GetFrequencyIncrement());
            else if (sender == nextNoteButton)
                MultiplyFrequency(GetFrequencyIncrement());
            else if (sender == minus2Button)
                MultiplyFrequency(1.0 / GetDoubleFrequencyIncrement());
            else if (sender == plus2Button)
                MultiplyFrequency(GetDoubleFrequencyIncrement());
            else if (sender == prevOctaveButton)
                MultiplyFrequency(0.5);
            else if (sender == nextOctaveButton)
                MultiplyFrequency(2.0);
        }

        private void leftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetLeft(leftCheckBox.Checked);
        }

        private void rightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetRight(rightCheckBox.Checked);
        }
    }
}
