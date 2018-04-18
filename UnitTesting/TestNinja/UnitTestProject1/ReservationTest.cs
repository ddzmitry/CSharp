using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTest
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User(){ IsAdmin = true});
            //Assert
            Assert.That(result,Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsUser_ReturnsTrue()
        {
            // Create a user
            var user = new User();
            //Set up that reservation is being made by this user
            var reservation = new Reservation(){MadeBy = user};
            // make sure we can cancel the reservation
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);


        }
        [Test]
        public void CanNotBeCancelledBy_UserIsNotUser_ReturnsFalse()
        {
            var user = new User();
            var user2 = new User();
            var reservation = new Reservation() { MadeBy = user };
            //Make sure that user2 can't cancel user reservation
            var result = reservation.CanBeCancelledBy(user2);
            Assert.IsFalse(result);


        }

    }
}
