using System;
using System.Text.RegularExpressions;

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
        
        /// <summary>
        /// Round function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Round(decimal value)
        {
            return Convert.ToDecimal(Math.Round(value));
        }
        /// <summary>
        /// Sinh function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Sinh(decimal value)
        {
            return Convert.ToDecimal(Math.Sinh(Convert.ToDouble(value)));
        }
        
        /// <summary>
        /// Cosh function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Cosh(decimal value)
        {
            return Convert.ToDecimal(Math.Cosh(Convert.ToDouble(value)));
        }
        
        /// <summary>
        /// Tanh function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Tanh(decimal value)
        {
            return Convert.ToDecimal(Math.Tanh(Convert.ToDouble(value)));
        }
        
        /// <summary>
        /// Ln function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Ln(decimal value)
        {
            return Convert.ToDecimal(Math.Log(Convert.ToDouble(value)));
        }
        
        /// <summary>
        /// LOG10 function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Log10(decimal value)
        {
            return Convert.ToDecimal(Math.Log10(Convert.ToDouble(value)));
        }
    }
}