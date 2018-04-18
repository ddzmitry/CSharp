using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace UnitTestProject1
{
    [TestFixture]
    public class HtmlFormaterTests
    {
        private HtmlFormatter _formater;

  
        [SetUp]
        public void SetUp()
        {
            _formater = new HtmlFormatter();
        }
        [TestCase("abc")]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement(string value)
        {
            var result = _formater.FormatAsBold(value);
            Assert.That(result, Is.EqualTo($"<strong>{value}</strong>"));
            Assert.That(result, Does.StartWith("<strong"));
            Assert.That(result, Does.EndWith("</strong>"));

        }
    }
}
