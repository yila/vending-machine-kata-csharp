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
    }
}
