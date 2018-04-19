using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;


namespace FizzBuzzTesting
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        [TestCase(3,"Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(11, "11")]
        [TestCase(null, "FizzBuzz")]

        public void FizzBuzz_BeingCalledWithNumber_WillReturnAppropriate_string(int number, string res)
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(res));
        }

        

    }
}
