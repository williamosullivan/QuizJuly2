using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                double j = Convert.ToDouble(i);
                if (j % 3 == 0)
                {
                    if (j % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else
                        Console.WriteLine("Fizz");
                }
                else if (j % 5 ==0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
