using AlgoDts.ImplemNet.CodeWars.WhoLike;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoDts.ImplTests.CodeWars
{
    [TestClass]
    public class WhoLikeTest
    {
        [TestMethod]
        public void Likes()
        {
            Assert.AreEqual("no one likes this", WhoLike.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", WhoLike.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", WhoLike.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", WhoLike.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLike.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
