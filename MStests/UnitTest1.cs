using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            library.Calc calc = new library.Calc();

            Assert.IsNotNull(calc);

            Assert.AreEqual(4, calc.Add(2, 2));
            Assert.AreNotEqual(4, calc.Add(3, 2));
        }
    }
}
