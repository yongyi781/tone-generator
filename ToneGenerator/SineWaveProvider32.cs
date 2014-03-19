using System;
using NAudio.Wave;

namespace ToneGenerator
{
    /// <summary>
    /// A wave provider that outputs a sine wave.
    /// </summary>
    class SineWaveProvider32 : WaveProvider32
    {
        /// <summary>
        /// The sample rate.
        /// </summary>
        public const int SAMPLE_RATE = 44100;
        /// <summary>
        /// Duration of the ramp in and out, in seconds.
        /// </summary>
        public const float RAMP_DURATION = 0.010f;
        /// <summary>
        /// The number of samples corresponding to the ramp duration.
        /// </summary>
        public const int RAMP_SAMPLES = (int)(SAMPLE_RATE * RAMP_DURATION);

        // The sample that the stop command was called at.
        private int stopSample = 0;

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
        /// Gets or sets whether the wave provider is in a playing state.
        /// </summary>
        public bool IsPlaying { get; set; }

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
            if (IsPlaying)
            {
                for (int i = 0; i < sampleCount; i += 2)
                {
                    float val = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * Sample) / sampleRate));
                    if (Sample < RAMP_SAMPLES)
                        val *= RampIn(Sample, RAMP_SAMPLES);
                    buffer[i + offset] = LeftChannelScaleFactor * val;
                    buffer[i + offset + 1] = RightChannelScaleFactor * val;
                    ++Sample;
                }
            }
            else
            {
                for (int i = 0; i < sampleCount; i += 2)
                {
                    float val = 0;
                    if (Sample < stopSample + RAMP_SAMPLES)
                        val = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * Sample) / sampleRate)) * RampOut(Sample - stopSample, RAMP_SAMPLES);
                    buffer[i + offset] = LeftChannelScaleFactor * val;
                    buffer[i + offset + 1] = RightChannelScaleFactor * val;
                    ++Sample;
                }
            }
            return sampleCount;
        }

        /// <summary>
        /// Initiates stopping, to allow the sound to ramp out.
        /// </summary>
        public void InitiateStop()
        {
            IsPlaying = false;
            stopSample = Sample;
        }

        // Cosine ramp in: 0.5 - 0.5*cos(pi*sample/threshold)
        private float RampIn(int sample, int rampSamples)
        {
            return 0.5f - 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
        }

        // Cosine ramp out: 0.5 + 0.5*cos(pi*sample/threshold)
        private float RampOut(int sample, int rampSamples)
        {
            return 0.5f + 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
        }
    }
}
