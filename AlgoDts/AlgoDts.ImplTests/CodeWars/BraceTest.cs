using AlgoDts.ImplemNet.CodeWars.Brace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoDts.ImplTests.CodeWars
{
    [TestClass]

    public class BraceTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(true, Brace.ValidBraces("()"));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(false, Brace.ValidBraces("[({})](]"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(true, Brace.ValidBraces(")"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(false, Brace.ValidBraces("[["));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(false, Brace.ValidBraces("[[]"));
        }
    }
}
