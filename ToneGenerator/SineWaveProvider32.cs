using System;
using NAudio.Wave;

namespace ToneGenerator
{
    class SineWaveProvider32 : WaveProvider32
    {
        int sample;

        public SineWaveProvider32()
            : base(48000, 2)
        {
            Frequency = 440f;
            Amplitude = 1.0f;
            PlayLeftChannel = true;
            PlayRightChannel = true;
        }

        public float Frequency { get; set; }
        public float Amplitude { get; set; }
        public bool PlayLeftChannel { get; set; }
        public bool PlayRightChannel { get; set; }

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            int sampleRate = WaveFormat.SampleRate;
            for (int i = 0; i < sampleCount; i += 2)
            {
                if (PlayLeftChannel)
                    buffer[i + offset] = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * sample) / sampleRate));
                if (PlayRightChannel)
                    buffer[i + offset + 1] = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * sample) / sampleRate));
                sample++;
            }
            return sampleCount;
        }
    }
}
