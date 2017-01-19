using NUnit.Framework;

namespace VendingMachineKata.UnitTests
{
    [TestFixture]
    public class CoinTests
    {
        [Test]
        public void DetermineValueOfQuarter()
        {
            var testObject = CoinFactory.Quarter();

            Assert.That(testObject.Value(), Is.EqualTo(25));

        }
        [Test]
        public void DetermineValueOfDime()
        {
            var testObject = CoinFactory.Dime();

            Assert.That(testObject.Value(), Is.EqualTo(10));

        }

        [Test]
        public void DetermineValueOfNickel()
        {
            var testObject = CoinFactory.Nickel();

            Assert.That(testObject.Value(), Is.EqualTo(5));

        }

        [Test]
        public void DetermineValueOfPenny()
        {
            var testObject = CoinFactory.Penny();

            Assert.That(testObject.Value(), Is.EqualTo(1));
        }

    }
}
