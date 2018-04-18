using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;


namespace UnitTestProject1
{
    [TestFixture]
    public class LogsTests
    {
        [Test]
        public void Log_WhenCalles_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError,Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            // have to get a delegator while writing an assertion
            // THIS IS VERY IMPORTANT
            Assert.That(()=>logger.Log(error),Throws.ArgumentNullException);
//            Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());

        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            //Event Based Testing
            // If Error Logged it will subscribe it
            logger.ErrorLogged += (sender, args) => { id = args;};
            logger.Log("a");
            Assert.That(id,Is.Not.EqualTo(Guid.Empty));
        }
    }
}
