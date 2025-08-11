using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sine_Cosine
    {
        public static void ComputeTrig(float deg, out float sinAngle, out float cosAngle)
        {
            // Convert degrees to radians
            float radians = deg * (float)(Math.PI / 180.0);

            // Calculate sine and cosine
            sinAngle = (float)Math.Sin(radians);
            cosAngle = (float)Math.Cos(radians);
        }
    }
}
