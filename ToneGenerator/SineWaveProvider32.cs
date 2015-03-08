using System;
using System.Collections.ObjectModel;
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
        public SineWaveProvider32() : base(SAMPLE_RATE, 2) { }

        public Collection<Soundtrack> Soundtracks { get; private set; } = new Collection<Soundtrack>();
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
                    float left = 0, right = 0;
                    foreach (var track in Soundtracks)
                    {
                        track.CurrentPhase += 2 * Math.PI * track.Frequency / sampleRate;

                        float val = (float)(track.Amplitude * Math.Sin(track.CurrentPhase));
                        if (track.Left)
                            left += val;
                        if (track.Right)
                            right += val;
                    }
                    if (Sample < RAMP_SAMPLES)
                    {
                        // Ramp in.
                        left *= RampIn(Sample, RAMP_SAMPLES);
                        right *= RampIn(Sample, RAMP_SAMPLES);
                    }
                    buffer[i + offset] = left;
                    buffer[i + offset + 1] = right;

                    ++Sample;
                }
            }
            else
            {
                // Not playing, but ramp out before stopping completely.
                for (int i = 0; i < sampleCount; i += 2)
                {
                    float left = 0, right = 0;
                    foreach (var track in Soundtracks)
                    {
                        float val = 0;
                        if (Sample < stopSample + RAMP_SAMPLES)
                        {
                            track.CurrentPhase += 2 * Math.PI * track.Frequency / sampleRate;
                            val = (float)(track.Amplitude * Math.Sin(track.CurrentPhase))
                                * RampOut(Sample - stopSample, RAMP_SAMPLES);
                        }
                        else
                        {
                            // Reset phase
                            track.CurrentPhase = 0;
                        }
                        if (track.Left)
                            left += val;
                        if (track.Right)
                            right += val;
                    }
                    buffer[i + offset] = left;
                    buffer[i + offset + 1] = right;

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
            foreach (var track in Soundtracks)
            {
            }
        }

        // Cosine ramp in: 0.5 - 0.5*cos(pi*sample/threshold)
        static float RampIn(int sample, int rampSamples)
        {
            return 0.5f - 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
        }

        // Cosine ramp out: 0.5 + 0.5*cos(pi*sample/threshold)
        static float RampOut(int sample, int rampSamples)
        {
            return 0.5f + 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
        }
    }
}
