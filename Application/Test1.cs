using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void Add2Plus2()
        {
            Calculator smart = new Calculator();
            Assert.That(smart.Add(2,2).Equals(4));
        }
        [Test]
        public void Multiply2By2()
        {
            Calculator smart = new Calculator();
            Assert.That(smart.Multiply(2, 2).Equals(4));
        }
    }
}