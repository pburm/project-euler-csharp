using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Utils;

namespace ProjectEulerTests
{
    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        public void OneIsPrime()
        {
            Assert.IsTrue(Numbers.IsPrime(1));
        }
    }
}
