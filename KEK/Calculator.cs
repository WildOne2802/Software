using System;

namespace KEK
{
    /// <summary>
    /// Class Calculator
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Sum function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public static decimal Sum(decimal firstValue, decimal secondValue)
        {
            return firstValue + secondValue;
        }

        /// <summary>
        /// Subtract function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public static decimal Subtract(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }

        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public static decimal Multiply(decimal firstValue, decimal secondValue)
        {
            return firstValue * secondValue;
        }

        /// <summary>
        /// Divide function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public static decimal Divide(decimal firstValue, decimal secondValue)
        {
            return firstValue / secondValue;
        }

        /// <summary>
        /// Power function
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        public static decimal Pow(decimal value, decimal pow)
        {
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(value), Convert.ToDouble(pow)));
        }

        /// <summary>
        /// Square root function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Sqrt(decimal value)
        {
            return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(value)));
        }

        /// <summary>
        /// Sin function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Sin(decimal value)
        {
            return Convert.ToDecimal(Math.Sin(Convert.ToDouble(value)));
        }

        /// <summary>
        /// Cos function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Cos(decimal value)
        {
            return Convert.ToDecimal(Math.Cos(Convert.ToDouble(value)));
        }

        /// <summary>
        /// Tan function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Tan(decimal value)
        {
            return Convert.ToDecimal(Math.Tan(Convert.ToDouble(value)));
        }

        /// <summary>
        /// Absolute function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Abs(decimal value)
        {
            return Convert.ToDecimal(Math.Abs(Convert.ToDouble(value)));
        }
    }
}