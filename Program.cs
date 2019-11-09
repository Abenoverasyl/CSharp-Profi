using System;

namespace LambdaExplression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1
            const int f = 5;
            Func<int, int> fun = n => n * f;

            var res = fun(10);

            Console.WriteLine(res);

            */

            var books = new BooksRepository().GetBooks();

            var cheepBooks = books.FindAll(book => book.Price < 100);

            foreach (var book in cheepBooks)
            {
                Console.WriteLine("{0} {1}", book.Title, book.Price);
            }

            Console.ReadKey();
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 100;
        //}
    }
}
