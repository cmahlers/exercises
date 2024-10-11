using System;
using System.Globalization;

namespace Exercises
{

    public class Exercises
    {
        public int closestNumber(int N, int M)
        {
            for (int i = 1; i <= M; i++)
            {
                if ((N + 1) % M == 0)
                {
                    return N + 1;
                }
                if ((N - 1) % M == 0)
                {
                    return N - 1;
                }
            }
        }

        public int MaxWidthRamp(int[] nums)
        {
            return 0;
        }
    }
}
