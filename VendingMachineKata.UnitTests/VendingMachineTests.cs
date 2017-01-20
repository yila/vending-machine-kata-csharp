using System.Linq;
using NUnit.Framework;
using VendingMachineKata.implementations;

namespace VendingMachineKata.UnitTests
{
    [TestFixture]
    public class VendingMachineTests
    {
        [Test]
        public void VendingMachineShouldDisplayDefaultMessageWhen()
        {
            var coinAcceptor = new CoinAcceptor();
            var displayPanel = new DisplayPanel();

            var testObject = new VendingMachine(coinAcceptor, displayPanel);

            var message = testObject.DisplayMessage();

            Assert.That(message, Is.EqualTo("INSERT COIN"));
        }

        [Test]
        public void VendingMachineShouldDisplayTheTotalWhenMultipleCoinsAreInserted()
        {
            var coinAcceptor = new CoinAcceptor();
            var displayPanel = new DisplayPanel();
            var testObject = new VendingMachine(coinAcceptor, displayPanel);
            testObject.AcceptCoin(CoinFactory.Quarter());
            testObject.AcceptCoin(CoinFactory.Quarter());
            testObject.AcceptCoin(CoinFactory.Quarter());
            
            var displayMessage = testObject.DisplayMessage();

            Assert.That(displayMessage, Is.EqualTo("$0.75"));
        }

        [Test]
        public void VendingMachineShouldSendRejectedCoinToTheCoinReturn()
        {
            var coinAcceptor = new CoinAcceptor();
            var displayPanel = new DisplayPanel();
            var testObject = new VendingMachine(coinAcceptor, displayPanel);
            testObject.AcceptCoin(CoinFactory.Quarter());
            testObject.AcceptCoin(CoinFactory.Penny());
            testObject.AcceptCoin(CoinFactory.Nickel());
            testObject.AcceptCoin(CoinFactory.Penny());

            var rejectedCoins = testObject.RejectedCoins();

            Assert.That(rejectedCoins.Count, Is.EqualTo(2));
            Assert.That(rejectedCoins.Select(x => x.WeightInGrams).Distinct().Single(), Is.EqualTo(CoinFactory.Penny().WeightInGrams));
            Assert.That(rejectedCoins.Select(x => x.DiameterInMilliMeter).Distinct().Single(), Is.EqualTo(CoinFactory.Penny().DiameterInMilliMeter));

        }

    }
}
