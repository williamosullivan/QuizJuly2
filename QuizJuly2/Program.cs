using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Please enter a number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            number2 = int.Parse(Console.ReadLine());
            BiggerNumber(number1, number2);
            Console.ReadLine();
        }

        public static void BiggerNumber(int first, int second)
        {
            if (first < second)
            {
                Console.WriteLine(first + " was the smaller number");
                Console.ReadLine();
            }
            else if (second < first)
            {
                Console.WriteLine(second + " was the smaller number");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
            }
        }
    }
}
