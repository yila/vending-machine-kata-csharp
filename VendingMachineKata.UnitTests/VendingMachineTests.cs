﻿using NUnit.Framework;
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
            coinAcceptor.AcceptCoin(new Coin { WeightInGrams = 5.67, DiameterInMilliMeter = 24.26});
            coinAcceptor.AcceptCoin(new Coin { WeightInGrams = 5.67, DiameterInMilliMeter = 24.26 });
            coinAcceptor.AcceptCoin(new Coin { WeightInGrams = 5.67, DiameterInMilliMeter = 24.26 });
            var displayPanel = new DisplayPanel();

            var testObject = new VendingMachine(coinAcceptor, displayPanel);
            
            var displayMessage = testObject.DisplayMessage();

            Assert.That(displayMessage, Is.EqualTo("$0.75"));
        }

    }
}
