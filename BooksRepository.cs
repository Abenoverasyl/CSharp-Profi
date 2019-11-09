
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExplression
{
    class BooksRepository
    {
        public new List<Book> GetBooks()
        {
            return new List<Book> {
                new Book { Title = "GGG", Price = 1 },
                new Book { Title = "GGG1", Price = 10 },
                new Book { Title = "GGG2", Price = 100 }
            };
        }
    }
}
