namespace ToneGenerator
{
	public class Soundtrack
	{
		public float Frequency { get; set; }
		public float Amplitude { get; set; }
		public bool Left { get; set; }
		public bool Right { get; set; }
		// Gets or sets the current phase of the soundtrack.
		public double CurrentPhase { get; set; }
	}
}
