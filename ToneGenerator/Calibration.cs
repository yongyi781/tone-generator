using System.Collections.Generic;
using System.Linq;

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
    }

    /// <summary>
    /// A calibration class using a dictionary for frequencies and amplitudes.
    /// </summary>
    public class Calibration2
    {
        private float minFrequency;
        private float maxFrequency;
        // Simple caching
        private float lastFrequency;
        private float lastAmplitudeDb;

        public Dictionary<float, float> AmplitudesDb { get; set; }

        public Calibration2(Dictionary<float, float> amplitudesDb)
        {
            AmplitudesDb = amplitudesDb;
            if (amplitudesDb != null)
            {
                minFrequency = amplitudesDb.Keys.Min();
                maxFrequency = amplitudesDb.Keys.Max();
            }
        }

        public static Calibration2 FromOldCalibration(Calibration calibration)
        {
            return new Calibration2(calibration.Frequencies.ToDictionary(f => f, f => calibration.GetAmplitudeDb(f)));
        }

        public float GetAmplitudeDb(float frequency)
        {
            if (frequency <= minFrequency)
                return AmplitudesDb[minFrequency];
            if (frequency >= maxFrequency)
                return AmplitudesDb[maxFrequency];

            // Simple caching, because this is going to be called over and over
            if (frequency == lastFrequency)
                return lastAmplitudeDb;

            var freqKeys = AmplitudesDb.Keys.Zip(AmplitudesDb.Keys.Skip(1), (a, b) => new { LowerKey = a, UpperKey = b })
                .Where(x => x.LowerKey <= frequency && x.UpperKey >= frequency)
                .FirstOrDefault();

            // Linear interpolation
            var t = (frequency - freqKeys.LowerKey) / (freqKeys.UpperKey - freqKeys.LowerKey);
            var amplitudeDb = (1 - t) * AmplitudesDb[freqKeys.LowerKey]
                + t * AmplitudesDb[freqKeys.UpperKey];
            lastFrequency = frequency;
            lastAmplitudeDb = amplitudeDb;
            return amplitudeDb;
        }

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
    }
}
