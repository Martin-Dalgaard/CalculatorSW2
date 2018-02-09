using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void Add2Plus2()
        {
            Calculator smart = new Calculator();
            Assert.That(smart.Add(2, 2).Equals(4));
        }
        [Test]
        public void Multiply2By2()
        {
            Calculator smart = new Calculator();
            Assert.That(smart.Multiply(2, 2).Equals(4));
        }
        [Test]
        public void Multiply3By2()
        {
            Calculator smart = new Calculator();
            Assert.That(smart.Multiply(3, 2).Equals(4));
        }
    }
}
