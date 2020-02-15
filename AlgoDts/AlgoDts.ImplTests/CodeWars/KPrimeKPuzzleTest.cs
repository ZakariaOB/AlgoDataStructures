using AlgoDts.ImplemNet.CodeWars.KPrime;
using AlgoDts.ImplemNet.CodeWars.KPrime.KPuzzle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgoDts.ImplTests.CodeWars
{
    [TestClass]
    public class KPrimeKPuzzleTest
    {
        [TestMethod]
        public void KPrimes_CountKprimes_Test()
        {
            testing(Array2String(KPrimes.CountKprimes(2, 0, 100)),
                Array2String(new long[]
                {4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51,
                 55, 57, 58, 62, 65, 69, 74, 77, 82, 85, 86, 87, 91, 93, 94, 95}));
            testing(Array2String(KPrimes.CountKprimes(3, 0, 100)),
                    Array2String(new long[]
                    {8, 12, 18, 20, 27, 28, 30, 42, 44, 45, 50, 52, 63, 66, 68, 70, 75, 76,
                 78, 92, 98, 99}));
            testing(Array2String(KPrimes.CountKprimes(5, 1000, 1100)),
                    Array2String(new long[]
                    {1020, 1026, 1032, 1044, 1050, 1053, 1064, 1072, 1092, 1100}));
            testing(Array2String(KPrimes.CountKprimes(5, 500, 600)),
                    Array2String(new long[]
                    {500, 520, 552, 567, 588, 592, 594}));
        }

        [TestMethod]
        public void KPuzzle_Check_Puzzle()
        {
            var puzzleOne = KPuzzle.Puzzle(138);
            var puzzleTwo = KPuzzle.Puzzle(143);


            var puzzle200 = KPuzzle.Puzzle(20000);

            Assert.AreEqual(puzzleOne, 1);
            Assert.AreEqual(puzzleTwo, 2);
        }

        [TestMethod]
        public void KPrimeFactors()
        {
            testing(Array2String(KPrimes.KPrimeFactors(20)),
                    Array2String(new long[]
                    {2, 2, 5}));
        }

        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
