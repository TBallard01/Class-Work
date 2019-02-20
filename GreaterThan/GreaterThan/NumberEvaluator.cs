using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterThan
{
    class NumberEvaluator
    {
        static void GreaterOrLesser(int num1, int num2)
        {
            if (num1 > num2) 
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            int number2 = int.Parse(Console.ReadLine());
            GreaterOrLesser(number1, number2);
            Console.ReadKey();
        }
    }
}
