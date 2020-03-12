using NUnit.Framework;

namespace KEK
{
    public class Tests
    {
        [Test]
        public void TestSum1()
        {
            Assert.AreEqual(4, Calculator.Sum(2, 2));
        }

        [Test]
        public void TestSum2()
        {
            Assert.AreNotEqual(5, Calculator.Sum(2, 2));
        }

        [Test]
        public void TestSubtract1()
        {
            Assert.AreEqual(5, Calculator.Subtract(10, 5));
        }

        [Test]
        public void TestSubtract2()
        {
            Assert.AreNotEqual(4, Calculator.Subtract(10, 5));
        }

        [Test]
        public void TestMultiply1()
        {
            Assert.AreEqual(4, Calculator.Multiply(2, 2));
        }

        [Test]
        public void TestMultiply2()
        {
            Assert.AreNotEqual(5,Calculator.Multiply(2,2));
        }
        
    }
}