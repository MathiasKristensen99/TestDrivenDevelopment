using NUnit.Framework;

namespace EASV.TestTechniques.Exercise1.Test
{
    public class GradeCalculatorTest
    {
        private IGradeCalculator _gradeCalculator;

        public GradeCalculatorTest()
        {
            _gradeCalculator = new GradeCalculator();
        }
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(5)]
        public void GradeIsMinusThree(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), -3);
        }

        [Test]
        [TestCase(6)]
        [TestCase(25)]
        [TestCase(49)]
        public void GradeIsZero(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 0);
        }

        [Test]
        [TestCase(50)]
        [TestCase(55)]
        [TestCase(59)]
        public void GradeIsTwo(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 2);
        }
    }
}