namespace ToneGenerator
{
	/// <summary>
	/// A calibration class using a dictionary for frequencies and amplitudes.
	/// </summary>
	public class Calibration
	{
		const int MaxCacheSize = 100;

		private readonly float minFrequency;
		private readonly float maxFrequency;
		// Simple caching
		private readonly Dictionary<float, float> cache = new();

		public Dictionary<float, float> AmplitudesDb { get; set; }

		public Calibration(Dictionary<float, float> amplitudesDb)
		{
			AmplitudesDb = amplitudesDb;
			if (amplitudesDb != null)
			{
				minFrequency = amplitudesDb.Keys.Min();
				maxFrequency = amplitudesDb.Keys.Max();
			}
		}

		public float GetAmplitudeDb(float frequency)
		{
			if (frequency <= minFrequency)
				return AmplitudesDb[minFrequency];
			if (frequency >= maxFrequency)
				return AmplitudesDb[maxFrequency];

			// Simple caching, because this is going to be called over and over
			if (cache.TryGetValue(frequency, out float result))
				return result;

			var freqKeys = AmplitudesDb.Keys.Zip(AmplitudesDb.Keys.Skip(1), (a, b) => new { LowerKey = a, UpperKey = b })
				.Where(x => x.LowerKey <= frequency && x.UpperKey >= frequency)
				.First();

			// Linear interpolation
			var t = (frequency - freqKeys.LowerKey) / (freqKeys.UpperKey - freqKeys.LowerKey);
			result = (1 - t) * AmplitudesDb[freqKeys.LowerKey]
				+ t * AmplitudesDb[freqKeys.UpperKey];

			if (cache.Count > MaxCacheSize)
				cache.Clear();
			cache[frequency] = result;
			return result;
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
