using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizJuly2_2
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal price1;
            decimal price2;
            Console.WriteLine("Enter price of the first book");
            price1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of the second book");
            price2 = decimal.Parse(Console.ReadLine());
            Book book = new Book(price1);
            Book book2 = new Book(price2);
            int value = Book.Compare(book, book2);
            Console.WriteLine("Return value is " + value);
            Console.ReadLine();
        }
    }
}
