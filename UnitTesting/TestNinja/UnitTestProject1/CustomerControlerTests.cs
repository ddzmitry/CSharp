using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;


namespace UnitTestProject1
{
    [TestFixture]
    public class CustomerControlerTests
    {
        private CustomerController _cc;
        [SetUp]
        public void SetUp()
        {
            _cc = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdZero_ReturnNotFound()
        {
            var result = _cc.GetCustomer(0);
            Assert.That(result,Is.TypeOf<NotFound>());
            //One of derivatives 

        }
        public void GetCustomer_IdNotZero_ReturnOk()
        {
            var result = _cc.GetCustomer(1);
            Assert.That(result,Is.TypeOf<Ok>());
        }
    }
}
