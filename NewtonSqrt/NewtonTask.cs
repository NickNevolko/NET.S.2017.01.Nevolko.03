using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSqrt
{
    /// <summary>
    /// static class with one method
    /// that calculate  n-root
    /// </summary>
    public static class NewtonTask
    {
        /// <summary>
        /// calculate root using Newton Method
        /// </summary>
        /// <param name="number">number of root to be founded</param>
        /// <param name="n">power of the number</param>
        /// <param name="eps">allowable error</param>
        /// <returns>returns a n-root of number</returns>
        public static double SqrtN(double number, int n, double eps)
        {
            if (number < 0)
            {
                throw new ArgumentException(nameof(eps));
            }

            if (eps < 0)
            {
                throw new ArgumentException(nameof(eps)); //ToDo fix
            }

            double x = number / 2;
            double xn = number;

            while (Math.Abs(x - xn) > eps)
            {
                xn = x;
                x = ((n - 1)*x + number/ Math.Pow(x, n - 1)) / n;
            }

            return x;
        }
    }
}
