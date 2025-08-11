using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Dot_Product
    {
        // vecA and vecB should have the same length
        public static float DotProduct(float[] vecA, float[] vecB)
        {
            float sum = 0f;

            for (int i = 0; i < vecA.Length; i++)
            {
                sum += vecA[i] * vecB[i];
            }

            return sum;
        }
    }
}
