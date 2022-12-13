using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneGenerator
{
    public static class Utilities
    {
        public static float DbToMag(float db) => (float)Math.Pow(10, db / 20);
        public static float MagToDb(float mag) => 20 * (float)Math.Log10(mag);
    }
}
