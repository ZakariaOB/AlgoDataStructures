namespace AgoDts.Impl.CodeWars.KPrime.KPuzzle
{
    public class KPuzzle
    {
        public int Puzzle(int s)
        {
            if (s == 0)
                return 0;

            var twoPrimes = KPrimes.CountKprimes(1, 0, s);
            var threePrimes = KPrimes.CountKprimes(3, 0, s);
            var sevenPrimes = KPrimes.CountKprimes(7, 0, s);
            /*
            int i = 0;
            int j = 0;
            int k = s;
            do
            {


                i--;

            }
            while (k > 0)*/
            return 0;
        }
    }
}
