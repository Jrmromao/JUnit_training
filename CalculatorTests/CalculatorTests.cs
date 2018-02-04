using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void ShoulAddInts()
        {
            var stu = new Calculator2.Calculator2();
            var result = stu.AddInt(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShoulAddDoubles()
        {
            var stu = new Calculator2.Calculator2();
            var result = stu.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));

        }



        [Test]
        public void ShoulAddDoubles_withPercentage()
        {
            var stu = new Calculator2.Calculator2();

            var result = stu.AddDoubles(50, 50);

            Assert.That(result, Is.EqualTo(101).Within(1).Percent);

        }


        [Test]
        public void ShoulAddDoubles_WithBadTolerance() 
        {
            var stu = new Calculator2.Calculator2();

            var result = stu.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.EqualTo(30).Within(100));

        }

        // Also available:
        //          Is.Positive
        //          Is.Negative
        //          Is.NaN


    }
}
