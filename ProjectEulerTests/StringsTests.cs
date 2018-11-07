using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Utils;

namespace ProjectEulerTests
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        public void ReverseReverses()
        {
            Assert.AreEqual("tset", "test".Reversed());
        }

        [TestMethod]
        public void BobIsPalindrome()
        {
            Assert.IsTrue(Strings.IsPalindrome("bob"));
        }
    }
}
