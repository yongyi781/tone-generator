using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneGenerator
{
    /// <summary>
    /// Alternates between two tones, specified by the first 2 soundtracks.
    /// </summary>
    [CLSCompliant(false)]
    public class AlternatingWaveProvider : SineWaveProvider
    {
        public AlternatingWaveProvider(float toneDuration)
        {
            ToneDuration = toneDuration;
        }

        // Tone duration in seconds.
        public float ToneDuration { get; set; }
        public int ToneSamples { get { return (int)(SAMPLE_RATE * ToneDuration); } }

        public int CurrentSoundtrackIndex { get; set; }
        public Soundtrack CurrentSoundtrack { get { return Soundtracks[CurrentSoundtrackIndex]; } }

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            if (IsPlaying)
            {
                for (int i = 0; i < sampleCount; i += 2)
                {
                    float left = 0, right = 0;
                    CurrentSoundtrack.CurrentPhase += 2 * Math.PI * CurrentSoundtrack.Frequency / WaveFormat.SampleRate;

                    float val = (float)(CurrentSoundtrack.Amplitude * Math.Sin(CurrentSoundtrack.CurrentPhase));
                    if (CurrentSoundtrack.Left)
                        left += val;
                    if (CurrentSoundtrack.Right)
                        right += val;
                    buffer[i + offset] = left;
                    buffer[i + offset + 1] = right;

                    ++Sample;
                    if (Sample % ToneSamples == 0)
                        SetSoundtrackIndex((Sample % (2 * ToneSamples)) / ToneSamples);
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
            var soundtrack = Soundtracks[index];
            soundtrack.CurrentPhase = CurrentSoundtrack.CurrentPhase;
            CurrentSoundtrackIndex = index;
        }
    }
}
