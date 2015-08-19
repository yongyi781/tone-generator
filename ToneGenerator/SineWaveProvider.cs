using NAudio.Wave;
using System;
using System.Collections.Generic;

namespace ToneGenerator
{
    public class Calibration
    {
        public Calibration(List<float> frequencies, List<float> amplitudes)
        {
            Frequencies = frequencies;
            AmplitudesDb = amplitudes;
        }

        public List<float> Frequencies { get; }
        public List<float> AmplitudesDb { get; }

        public float GetCalibratedAmplitude(Soundtrack track, bool useLoudness = true)
        {
            // Loudness normalization: 120 dB -> 0 dBFS, 0 dB -> threshold
            const float MaxDb = 120;
            var thresholdDb = GetAmplitudeDb(track.Frequency);
            var amplitudeDb = Utilities.MagToDb(track.Amplitude);
            if (useLoudness)
                amplitudeDb = -thresholdDb / MaxDb * (amplitudeDb - MaxDb);
            else
                amplitudeDb += thresholdDb;
            return Utilities.DbToMag(amplitudeDb);
        }

        public float GetAmplitudeDb(float frequency)
        {
            int index = Frequencies.BinarySearch(frequency);
            if (index >= 0)
                return AmplitudesDb[index];
            // Linear interpolation
            int nextLargestIndex = ~index;
            if (nextLargestIndex == 0)
                return AmplitudesDb[0];
            if (nextLargestIndex == Frequencies.Count)
                return AmplitudesDb[AmplitudesDb.Count - 1];

            float leftFreq = Frequencies[nextLargestIndex - 1];
            float rightFreq = Frequencies[nextLargestIndex];
            float t = (frequency - leftFreq) / (rightFreq - leftFreq);

            return (1 - t) * AmplitudesDb[nextLargestIndex - 1]
                + t * AmplitudesDb[nextLargestIndex];
        }
    }

    /// <summary>
    /// A wave provider that outputs a sine wave.
    /// </summary>
    [CLSCompliant(false)]
    public class SineWaveProvider : WaveProvider32
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
        /// Creates a new <see cref="SineWaveProvider"/> with default settings.
        /// </summary>
        public SineWaveProvider() : base(SAMPLE_RATE, 2) { }

        public List<Soundtrack> Soundtracks { get; private set; } = new List<Soundtrack>();
        /// <summary>
        /// Gets or sets the current sample count.
        /// </summary>
        public int Sample { get; set; }
        /// <summary>
        /// Gets or sets whether the wave provider is in a playing state.
        /// </summary>
        public bool IsPlaying { get; set; }
        /// <summary>
        /// Gets or sets the calibration of the output sound.
        /// </summary>
        public Calibration LeftCalibration { get; set; } = new Calibration(new List<float> { 1000 }, new List<float> { 0 });
        /// <summary>
        /// Gets or sets the calibration of the output sound.
        /// </summary>
        public Calibration RightCalibration { get; set; } = new Calibration(new List<float> { 1000 }, new List<float> { 0 });
        public bool UseLoudnessInCalibration { get; set; }

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

                        float val = (float)(Math.Sin(track.CurrentPhase));
                        if (track.Left)
                            left += LeftCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
                        if (track.Right)
                            right += RightCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
                    }
                    if (Sample < RAMP_SAMPLES)
                    {
                        // Ramp in.
                        left *= HannIn(Sample, RAMP_SAMPLES);
                        right *= HannIn(Sample, RAMP_SAMPLES);
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
                            val = (float)(Math.Sin(track.CurrentPhase))
                                * HannOut(Sample - stopSample, RAMP_SAMPLES);
                        }
                        else
                        {
                            // Reset phase
                            track.CurrentPhase = 0;
                        }
                        if (track.Left)
                            left += LeftCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
                        if (track.Right)
                            right += RightCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
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
        }

        // Cosine ramp in: 0.5 - 0.5*cos(pi*sample/threshold)
        static float HannIn(int sample, int rampSamples) =>
            0.5f - 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);

        // Cosine ramp out: 0.5 + 0.5*cos(pi*sample/threshold)
        static float HannOut(int sample, int rampSamples) =>
            0.5f + 0.5f * (float)Math.Cos(Math.PI * sample / rampSamples);
   }
}
