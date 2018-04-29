using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOperators
{
    class Program
    {
        delegate double Operation(double firstNumber, double secondNumber);

        static void Main(string[] args)
        {
            Operation add = (x, y) => x + y;
            Operation sub = (x, y) => x - y;
            Operation mul = (x, y) => x * y;
            Operation div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Error, dividing on 0!");
                    return -1;
                }
                else
                {
                    return x / y;
                }
            };

            Console.Write("Please, enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please, enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result;

            Console.Write("Please, enter operation (+, -, *, /) : ");
            switch (Console.ReadLine())
            {
                case "+":
                    result = add(firstNumber, secondNumber);
                    break;
                case "-":
                    result = sub(firstNumber, secondNumber);
                    break;
                case "*":
                    result = mul(firstNumber, secondNumber);
                    break;
                case "/":
                    result = div(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    result = 0;
                    break;
            }

            Console.WriteLine($"The answer is {result}");
            Console.ReadKey();
        }
    }
}
