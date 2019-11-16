using Generics;
using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 30
                orderby b.Title
                select b;

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 30)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheaperBooks)
                Console.WriteLine(book);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);

        }
    }
}
