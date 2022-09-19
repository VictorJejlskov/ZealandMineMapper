using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        /// <summary>
        /// Calculates the value of adding together number1 and number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Double</returns>
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        /// <summary>
        /// Calculates the value of subtracting the value of number2 from number1
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Double</returns>
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
        /// <summary>
        /// Calculates the value of multiplying the value of number1 with number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Double</returns>
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        /// <summary>
        /// Calculates the value of dividing the value of number1 by number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Double</returns>
        public static double Divide(double number1, double number2)
        {
            return (number1 / number2);
        }
        /// <summary>
        /// Calculates the value of putting number1 in the power of number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Double</returns>
        public static double PowerOf(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }
        /// <summary>
        /// Calculates the cosinus value for number1
        /// </summary>
        /// <param name="number1"></param>
        /// <returns>Double</returns>
        public static double Cosinus(double number1)
        {
            return Math.Cos(number1);
        }
        /// <summary>
        /// Calculates the sinus value for number1 
        /// </summary>
        /// <param name="number1"></param>
        /// <returns>Double</returns>
        public static double Sinus(double number1)
        {
            return Math.Sin(number1);
        }
        /// <summary>
        /// Calculates the square root of number1
        /// </summary>
        /// <param name="number1"></param>
        /// <returns>Double</returns>
        public static double Squareroot(double number1)
        {
            return Math.Sqrt(number1);
        }
        /// <summary>
        /// Returns the value of Pi
        /// </summary>
        /// <returns>Double</returns>
        public static double Pi()
        {
            return Math.PI;
        }
    }
}
