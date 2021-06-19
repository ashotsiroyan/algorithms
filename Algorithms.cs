using System;

namespace algorithms
{
    public class Algorithms
    {
        public static double degree(double num, double x)
        {
            double c = num;
            double d = x;
            double r = 1;

            while (d > 0)
            {
                if (d % 2 == 1)
                    r *= c;

                d = Math.Truncate(d / 2);
                c *= c;
            }

            return r;
        }

        public static double degreeMod(double num, double x, int mod)
        {
            double c = num % mod;
            double d = x;
            double r = 1;

            while (d > 0)
            {
                if (d % 2 == 1)
                    r = (r * c) % mod;

                d = Math.Truncate(d / 2);
                c = (c * c) % mod;
            }

            return r;
        }

        public static int bitwiseDegree(int num, int x)
        {
            int c = num;
            int d = x;
            int r = 1;

            while (d > 0)
            {
                if ((d & 00000001) == 1)
                    r *= c;

                d = d >> 1;
                c *= c;
            }

            return r;
        }

        public static int bitwiseDegreeMod(int num, int x, int mod)
        {
            int c = num % mod;
            int d = x;
            int r = 1;

            while (d > 0)
            {
                if ((d & 00000001) == 1)
                    r = (r * c) % mod;

                d = d >> 1;
                c = (c * c) % mod;
            }

            return r;
        }
    }
}
