using System;
using System.Collections.Generic;
using System.Linq;

namespace AgoDts.Impl.CodeWars.KPrime
{
    public class KPrimes
    {
        public void Main()
        {
            throw new NotImplementedException();
        }

        public static long[] CountKprimes(long kFactor, long xlongervalle, long ylongervalle)
        {
            List<long> primes = new List<long>();
            List<long> kFactors = new List<long>();
            for (long i = xlongervalle; i <= ylongervalle; i++)
            {
                if (kFactor == 1)
                {
                    kFactors.Add(i);
                    continue;
                }
                long kFactorCount = 0;
                for (long j = 2; i <= Math.Ceiling(Math.Sqrt(i)); j++)
                {
                    if ((primes.Contains(j) || IsPrime(j)) && !kFactors.Contains(j) && i % j == 0)
                    {
                        kFactorCount++;
                        primes.Add(j);
                    }
                }
                if (kFactorCount == kFactor)
                {
                    kFactors.Add(i);
                }
            }
            return kFactors.ToArray();
        }
        private static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var limit = Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
