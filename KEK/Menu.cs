using System;

namespace KEK
{
    /// <summary>
    /// Class Menu
    /// </summary>
    public class Menu
    {
        private decimal result = 0;

        /// <summary>
        /// EnterValue function for menu
        /// </summary>
        /// <returns></returns>
        private decimal EnterValue()
        {
            var flag = false;
            decimal value = 0;
            while (!flag)
            {
                var inputLine = Console.ReadLine();
                if (!Decimal.TryParse(inputLine, out value))
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    flag = true;
                }
            }

            Console.Clear();
            return value;
        }

        /// <summary>
        /// Result function for menu
        /// </summary>
        private void Result()
        {
            Console.WriteLine(result);
        }

        /// <summary>
        /// Start function for menu
        /// </summary>
        public void Start()
        {
            string inputLine;
            while (true)
            {
                Console.WriteLine(
                    "[1] EnterValue\n[2] Sum\n[3] Subtract\n[4] Multiply\n[5] Divide\n[6] Pow\n[7] Sqrt\n[8] Sin\n[9] Cos\n[10] Tan\n[11] Absolute\n[12] Round\n[13] Sinh\n[14] Cosh\n[15] Result\n[0] Exit\n");
                inputLine = Console.ReadLine();
                if (!Int32.TryParse(inputLine, out var operation))
                {
                    Console.WriteLine("Error");
                    continue;
                }

                try
                {
                    switch (operation)
                    {
                        case 1:
                            result = EnterValue();
                            Result();
                            break;
                        case 2:
                            result = Calculator.Sum(result, EnterValue());
                            Result();
                            break;
                        case 3:
                            result = Calculator.Subtract(result, EnterValue());
                            Result();
                            break;
                        case 4:
                            result = Calculator.Multiply(result, EnterValue());
                            Result();
                            break;
                        case 5:
                            result = Calculator.Divide(result, EnterValue());
                            Result();
                            break;
                        case 6:
                            result = Calculator.Pow(result, EnterValue());
                            Result();
                            break;
                        case 7:
                            result = Calculator.Sqrt(result);
                            Result();
                            break;
                        case 8:
                            result = Calculator.Sin(result);
                            Result();
                            break;
                        case 9:
                            result = Calculator.Cos(result);
                            Result();
                            break;
                        case 10:
                            result = Calculator.Tan(result);
                            Result();
                            break;
                        case 11:
                            result = Calculator.Abs(result);
                            Result();
                            break;
                        case 12:
                            result = Calculator.Round(result);
                            Result();
                            break;
                        case 13:
                            result = Calculator.Sinh(result);
                            Result();
                            break;
                        case 14:
                            result = Calculator.Cosh(result);
                            Result();
                            break;
                        case 15:
                            Result();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}