using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using VendingMachineKata.interfaces;

namespace VendingMachineKata.UnitTests
{
    [TestFixture]
    public class VendingMachineTests
    {
        [Test]
        public void VendingMachineShouldDisplayDefaultMessageWhen()
        {
            var mockCoinAcceptor = new Mock<ICoinAcceptor>();
            var mockDisplay = new Mock<IDisplay>();
            mockCoinAcceptor.Setup(x => x.TotalAmount).Returns(0);
            mockDisplay.Setup(x => x.DisplayAmount(0)).Returns("INSERT COIN");
            var testObject = new VendingMachine(mockCoinAcceptor.Object, mockDisplay.Object);

            var message = testObject.DisplayMessage();

            Assert.That(message, Is.EqualTo("INSERT COIN"));
        }

        [Test]
        public void VendingMachineShouldDisplayTheTotalWhenMultipleCoinsAreInserted()
        {
            var mockCoinAcceptor = new Mock<ICoinAcceptor>();
            var mockDisplay = new Mock<IDisplay>();
            mockCoinAcceptor.Setup(x => x.TotalAmount).Returns(75);
            mockDisplay.Setup(x => x.DisplayAmount(75)).Returns("75 cents");
            var testObject = new VendingMachine(mockCoinAcceptor.Object, mockDisplay.Object);
            
            var displayMessage = testObject.DisplayMessage();

            Assert.That(displayMessage, Is.EqualTo("75 cents"));
        }

    }
}
