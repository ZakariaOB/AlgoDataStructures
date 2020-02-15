using System.Collections.Generic;
using System.Text;

namespace AlgoDts.ImplemNet.CodeWars.KPrime.KPuzzle
{
    public class KPuzzle
    {
        public static int Puzzle(int s)
        {
            if (s == 0)
                return 0;

            List<long> primes = new List<long>();
            var onePrimes = KPrimes.CountKprimes(1, 2, s);
            var threePrimes = KPrimes.CountKprimes(3, 0, s);
            var sevenPrimes = KPrimes.CountKprimes(7, 0, s);

            int numberOfSolutions = 0;

            foreach(var onePrime in onePrimes)
            {
                foreach(var threePrime in threePrimes)
                {
                    foreach(var sevenPrime in sevenPrimes)
                    {
                        if ((onePrime + threePrime + sevenPrime) == s)
                        {
                            numberOfSolutions++;
                            break;
                        }
                    }
                }
            }


            return numberOfSolutions;
        }

    }
}
