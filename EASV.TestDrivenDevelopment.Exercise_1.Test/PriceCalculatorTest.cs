using NUnit.Framework;

namespace EASV.TestDrivenDevelopment.Exercise_1.Test
{
    public class PriceCalculatorTest
    {
        PriceCalculator _priceCalculator;

        public PriceCalculatorTest()
        {
            _priceCalculator = new PriceCalculator();
        }
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KilometerBelow100()
        {
            Assert.AreEqual(142.8, _priceCalculator.TotalCost(0, 4));
        }

        [Test]
        public void KilometerAbove100AndPassengersBelow12()
        {
            Assert.AreEqual(680, _priceCalculator.TotalCost(6, 200));
        }

        [Test]
        public void KilometerAbove100AndPassengersAbove12()
        {
            Assert.AreEqual(661, _priceCalculator.TotalCost(22, 177));
        }

        [Test]
        public void KilometerAbove500()
        {
            Assert.AreEqual(1302.25, _priceCalculator.TotalCost(8, 521));
        }
    }
}