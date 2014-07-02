using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizJuly2_2
{
    class Book
    {
        private decimal price;
        public Book(decimal bookPrice)
        {
            this.price = bookPrice;
        }

        public static int Compare(Book book1, Book book2)
        {
            if (book1.price == book2.price)
                return 0;
            else if (book1.price > book2.price)
                return 1;
            else
                return -1;
        }
    }
}
