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

        [Test]
        [TestCase(60)]
        [TestCase(64)]
        [TestCase(79)]
        public void GradeIsFour(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 4);
        }

        [Test]
        [TestCase(80)]
        [TestCase(82)]
        [TestCase(84)]
        public void GradeIsSeven(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 7);
        }

        [Test]
        [TestCase(85)]
        [TestCase(87)]
        [TestCase(94)]
        public void GradeIsTen(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 10);
        }

        [Test]
        [TestCase(98)]
        public void GradeIsTwelfth(int n)
        {
            Assert.AreEqual(_gradeCalculator.ToGrade(n), 12);
        }
    }
}