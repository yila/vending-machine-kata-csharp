using NUnit.Framework;
using VendingMachineKata.implementations;

namespace VendingMachineKata.UnitTests
{
    [TestFixture]
    public class DisplayPanelTests
    {
        [Test]
        public void ShouldDisplayDefaultMessageIfAmountIsZero()
        {
            var testObject = new DisplayPanel();

            var displayedAmount = testObject.DisplayAmount(0);

            Assert.That(displayedAmount, Is.EqualTo("INSERT COIN"));
        }

        [TestCase(125, "$1.25")]
        [TestCase(100, "$1.00")]
        [TestCase(340, "$3.40")]
        [TestCase(87, "$0.87")]
        [TestCase(5, "$0.05")]
        [TestCase(50, "$0.50")]
        public void ShouldConvertAmountToProperDollarFormat(int amount, string expectedDisplay)
        {
            var testObject = new DisplayPanel();

            var displayedAmount = testObject.DisplayAmount(amount);

            Assert.That(displayedAmount, Is.EqualTo(expectedDisplay));
        }
    }
}
