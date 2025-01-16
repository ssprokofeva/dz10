using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tum12
{
    internal class BooksContainer
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void SortBooks(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
