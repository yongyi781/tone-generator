using System;
using NAudio.Wave;

namespace ToneGenerator
{
    /// <summary>
    /// A wave provider that outputs a sine wave.
    /// </summary>
    class SineWaveProvider32 : WaveProvider32
    {
        const int SAMPLE_RATE = 44100;
        const int RAMP_SAMPLES = SAMPLE_RATE / 100;

        /// <summary>
        /// Creates a new <see cref="SineWaveProvider32"/> with default settings.
        /// </summary>
        public SineWaveProvider32()
            : base(SAMPLE_RATE, 2)
        {
            Frequency = 440f;
            Amplitude = 1.0f;
            LeftChannelScaleFactor = 1f;
            RightChannelScaleFactor = 1f;
        }

        /// <summary>
        /// Gets or sets the frequency of the sine wave.
        /// </summary>
        public float Frequency { get; set; }
        /// <summary>
        /// Gets or sets the amplitude of the sine wave.
        /// </summary>
        public float Amplitude { get; set; }
        /// <summary>
        /// The scale factor of the amplitude for the left channel. Must be between 0 and 1.
        /// </summary>
        public float LeftChannelScaleFactor { get; set; }
        /// <summary>
        /// The scale factor of the amplitude for the right channel. Must be between 0 and 1.
        /// </summary>
        public float RightChannelScaleFactor { get; set; }
        /// <summary>
        /// Gets or sets the current sample count.
        /// </summary>
        public int Sample { get; set; }

        /// <summary>
        /// Reads in a buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="sampleCount">The number of samples.</param>
        /// <returns>The sample count.</returns>
        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            int sampleRate = WaveFormat.SampleRate;
            for (int i = 0; i < sampleCount; i += 2)
            {
                float val = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * Sample) / sampleRate));
                if (Sample < RAMP_SAMPLES)
                    val *= InterpolateAmplitude(Sample, RAMP_SAMPLES);
                buffer[i + offset] = LeftChannelScaleFactor * val;
                buffer[i + offset + 1] = RightChannelScaleFactor * val;
                ++Sample;
            }
            return sampleCount;
        }

        // Cosine ramp: 0.5 - 0.5*cos(pi*sample/threshold)
        private float InterpolateAmplitude(int sample, int rampSamples)
        {
            return 0.5f - 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
        }
    }
}
