
using System;
namespace MyCalculator
{
    public class Calculator : ICalculator
    {
        #region Public Methods

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Can't divide by zero!");
            }

            return x / y;
        }

        public double Pythagorus(int a, int b)
        {
            return  Math.Sqrt(a*a + b*b);

        }

        #endregion
    }
}
