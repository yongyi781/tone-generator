using System;
using System.Windows.Forms;

namespace ToneGenerator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(false);

            int desiredLatency = Form1.DefaultLatency;
            if (args.Length >= 2 && (args[0] == "-l" || args[0] == "-latency"))
                if (!int.TryParse(args[1], out desiredLatency))
                    desiredLatency = Form1.DefaultLatency;
			Application.Run(new Form1(desiredLatency));
		}
	}
}
