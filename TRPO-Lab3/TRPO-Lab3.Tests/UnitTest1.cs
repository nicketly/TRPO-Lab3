using NUnit.Framework;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputationalTest()     //Вычислительный тест
        {
            double a = 4;
            double h = 2;

            var result = FormulaLib.Pyramid_Reg4_Volume(a, h);

            double expected = 10.6;
            Assert.AreEqual(expected, result, 0.1);
        }

        [Test]
        public void BoundaryTest()          //Граничный тест
        {
            double a = 4;
            double h = -2;

            Assert.Throws<Exception>(() => FormulaLib.Pyramid_Reg4_Volume(a, h));
        }
    }
}