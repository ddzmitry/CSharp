using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Math = TestNinja.Fundamentals.Math;


namespace UnitTestProject1
{
    [TestFixture()]
    public class MathTest
    {
        private Math _math;
        //SetUp
        //TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]  
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        { 
            var result = _math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
            
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsGreaterArgument(int a, int b , int expectedResult)
        {
            var result = _math.Max(a,b);
            Assert.That(result,Is.EqualTo(expectedResult));
        }

        [Test]
//        [Ignore("Because I am tupid!")]
        public void GetOddNumbers_WhenCalled_returnsListOfOddNumbers()
        {
            
            var result = _math.GetOddNumbers(3);
            Assert.That(result,Is.EqualTo(new List<int>() { 1, 3 }));


        }
        [Test]
        public void GetOddNumbers_WhenCalledWithZero_returnsEmptyList()
        {
            
            var result = _math.GetOddNumbers(0);
            Assert.That(result, Is.EqualTo(new List<int>()));
        }

    }
}
