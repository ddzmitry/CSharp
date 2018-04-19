using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject1
{
    [TestFixture]
    public class DemeritPointCalculatorTest
    {
       
        [Test]
        [TestCase(55,0)]
        [TestCase(70, 1)]
        public void DemeritPointCalculator_WhenExecuted_WillReturnProperly(int speed,int points)
        {
            var calc = new DemeritPointsCalculator();
            //Assert.That(()=>logger.Log(error),Throws.ArgumentNullException);
            var result = calc.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(points));

        }

        [Test]
        [TestCase(-1)]
        [TestCase(650)]
        public void DemeritPointCalculator_WhenCalledWithZeroOrMaxSpeed_ReturnError(int number)
        {
            var calc = new DemeritPointsCalculator();
            Assert.That(() => calc.CalculateDemeritPoints(number),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
