using System;

namespace ToneGenerator
{
    /// <summary>
    /// Alternates between two sides, each having 3 soundtracks (in the current implementation).
    /// </summary>
    [CLSCompliant(false)]
    public class AlternatingWaveProvider : SineWaveProvider
    {
        public AlternatingWaveProvider(double period)
        {
            Period = period;
        }

        public double Period { get; set; }
        // Tone duration in seconds.
        public double ToneDuration { get { return Period; } }
        public int ToneSamples { get { return (int)(SAMPLE_RATE * ToneDuration); } }

        // 0 if left side is being played, 1 if right side.
        public int CurrentSoundtrackIndex { get; set; }
        public double DutyCycle { get; set; } = 0.5;

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            if (IsPlaying)
            {
                for (int i = 0; i < sampleCount; i += 2)
                {
                    float left = 0, right = 0;
                    for (int j = CurrentSoundtrackIndex; j < Soundtracks.Count; j += 2)
                    {
                        var track = Soundtracks[j];
                        track.CurrentPhase += 2 * Math.PI * track.Frequency / WaveFormat.SampleRate;

                        float val = (float)(Math.Sin(track.CurrentPhase));
                        if (track.Left)
                            left += LeftCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
                        if (track.Right)
                            right += RightCalibration.GetCalibratedAmplitude(track, UseLoudnessInCalibration) * val;
                    }
                    buffer[i + offset] = left;
                    buffer[i + offset + 1] = right;

                    ++Sample;
                    if (Sample % ToneSamples == 0)
                        SetSoundtrackIndex(0);
                    else if (Sample % ToneSamples == (int)((1 - DutyCycle) * ToneSamples))
                        SetSoundtrackIndex(1);
                }
            }
            else
            {
                for (int i = 0; i < sampleCount; i++)
                {
                    buffer[i + offset] = 0;
                }
            }

            return sampleCount;
        }

        private void SetSoundtrackIndex(int index)
        {
            int d = index == 0 ? 1 : -1;
            for (int i = index; Math.Max(i, i + d) < Soundtracks.Count; i += 2)
            {
                // Move current phase into phase of soundtrack on other side
                Soundtracks[i].CurrentPhase = Soundtracks[i + d].CurrentPhase;
            }
            CurrentSoundtrackIndex = index;
        }
    }
}
