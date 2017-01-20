using NUnit.Framework;
using VendingMachineKata.implementations;

namespace VendingMachineKata.UnitTests
{
    [TestFixture]
    public class CoinAcceptorTests
    {
        [Test]
        public void AcceptCoinShouldAddToTotalAmountEverytimeACoinIsInserted()
        {
            var testObject = new CoinAcceptor();

            testObject.AcceptCoin(CoinFactory.Quarter());
            testObject.AcceptCoin(CoinFactory.Dime());
            testObject.AcceptCoin(CoinFactory.Nickel());

            Assert.That(testObject.TotalAmount, Is.EqualTo(40));
        }

        [Test]
        public void CoinAcceptorShouldAcceptValidCoin_Quarter()
        {
            var testObject = new CoinAcceptor();

            Assert.That(testObject.AcceptCoin(CoinFactory.Quarter()), Is.EqualTo(true));
        }

        [Test]
        public void CoinAcceptorShouldAcceptValidCoin_Nickel()
        {
            var testObject = new CoinAcceptor();

            Assert.That(testObject.AcceptCoin(CoinFactory.Nickel()), Is.EqualTo(true));
        }

        [Test]
        public void CoinAcceptorShouldAcceptValidCoin_Dime()
        {
            var testObject = new CoinAcceptor();

            Assert.That(testObject.AcceptCoin(CoinFactory.Dime()), Is.EqualTo(true));
        }

        [Test]
        public void CoinAcceptorShouldRejectAnInvalidCoin_Penny()
        {
            var testObject = new CoinAcceptor();

            Assert.That(testObject.AcceptCoin(CoinFactory.Penny()), Is.EqualTo(false));
        }
    }
}
