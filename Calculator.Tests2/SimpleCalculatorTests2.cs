using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests2
{

    [TestFixture]
    public class SimpleCalculatorTests2
    {

        [Test]
        public void Sshould_addTwoNumbers()
        {
            var stu = new SimpleCalculator();
            var result = stu.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        public void Sshould_MultiplyTwoNumbers()
        {
            var stu = new SimpleCalculator();
            var result = stu.Multiply(2, 10);
            Assert.That(result, Is.EqualTo(20));
        }



    }
}
