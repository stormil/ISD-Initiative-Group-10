using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    static class Calculator
    {
        public static int Plus(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Minus(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Division(int firstNumber, int secondNumber)
        {
            try
            {
                return firstNumber / secondNumber;
            }
            catch(Exception e)
            {
                Console.Write("Division on 0: ");
                return -1;
            }
        }
    }
}
