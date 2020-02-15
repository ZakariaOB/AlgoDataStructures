using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoDts.ImplemNet.CodeWars.KPrime
{
    public class KPrimes
    {
        public void Main()
        {
            throw new NotImplementedException();
        }


        public static long[] CountKprimes(long k, long start, long end)
        {
            List<long> kFactors = new List<long>();
            for (long i = start; i <= end; i++)
            {
                long v = 2;
                long o = i;
                int x = 0;
                while (v <= Math.Floor(Math.Sqrt(o)))
                {
                    while (o % v == 0)
                    {
                        o /= v;
                        x++;
                    }
                    v++;
                }

                if (o > 1)
                {
                    x++;
                }
                if (x == k)
                {
                    kFactors.Add(i);
                }
            }
            return kFactors.ToArray();
        }



        public static long[] KPrimeFactors(int number)
        {
            List<long> result = new List<long>();
            int b = 2;
            while (number > 1)
            {
                if (number % b == 0)
                {
                    int x = 0;
                    while (number % b == 0)
                    {
                        number /= b;
                        x++;
                        result.Add(b);
                    }
                }
                b++;
            }
            return result.ToArray();
        }
    }
}
