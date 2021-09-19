using EASV.TestDrivenDevelopment.Exercise_2;
using NUnit.Framework;

namespace EASV.TestDrivenDevelopment.Exercise_2_Test
{
    public class CloudBurstCalculatorTest
    {
        private ICloudBurstCalculator _cloudBurstCalculator;

        public CloudBurstCalculatorTest()
        {
            _cloudBurstCalculator = new CloudBurstCalculator();
        }
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double[] cloudburst = new double[] {2, 4, 6};
            
            Assert.AreEqual(6, _cloudBurstCalculator.ContainsCloudburst(cloudburst));
        }

        [Test]
        public void Test2()
        {
            double[] cloudbursts = new double[] {2, 4};
            
            Assert.AreEqual(-1, _cloudBurstCalculator.ContainsCloudburst(cloudbursts));
        }
    }
}