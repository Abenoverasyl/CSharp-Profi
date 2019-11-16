using System;
using System.Collections.Generic;
using System.Text;
using Generics;

namespace Linq
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "First", Price = 5},
                new Book() {Title = "Sec", Price = 15},
                new Book() {Title = "Thir", Price = 55},
                new Book() {Title = "Four", Price = 25},
                new Book() {Title = "Five", Price = 35}
            };
        }
    }
}
