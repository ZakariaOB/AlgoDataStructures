using System;
using AlgoDts.ImplemNet.CodeWars.MakeComplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoDts.ImplTests.CodeWars
{
    [TestClass]
    public class MakeComplement_Test
    {
        [TestMethod]
        public void test01()
        {
            Assert.AreEqual("TTTT", DnaTester.MakeComplement("AAAA"));
        }
        [TestMethod]
        public void test02()
        {
            Assert.AreEqual("TAACG", DnaTester.MakeComplement("ATTGC"));
        }
        [TestMethod]
        public void test03()
        {
            Assert.AreEqual("CATA", DnaTester.MakeComplement("GTAT"));
        }
    }
}
