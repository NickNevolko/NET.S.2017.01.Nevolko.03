using NUnit.Framework;
using static NewtonSqrt.NewtonTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TestsNewton
{
    [TestFixture]
    public class TestNewtonMethod
    {
        //ToDo fixes
        [TestCase(100, 2, 0.0000000001d, ExpectedResult = 10)]
        [TestCase(9, 2, 0.000000000001d, ExpectedResult = 3)]
        [TestCase(64, 2, 0.00000000001d, ExpectedResult = 8)]
        [TestCase(81, 4, 0.000000000001d, ExpectedResult = 3)]
        public double TestNewton(double number, int n, double eps)
        {
            return SqrtN(number, n, eps);
        }

        [TestCase(-5, 2, 0.01d)]
        [TestCase(5, 2, -0.01d)]
        public void TestNewtonIncorrect(double number, int n, double eps)
        {
            Assert.Throws<ArgumentException>(() => SqrtN(number, n, eps));
        }
    }
}
