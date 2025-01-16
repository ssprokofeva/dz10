using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tum12
{
    internal class Program
    {
        private static Comparison<Book> GetCompareByTitle()
        {
            return CompareByTitle;
        }

        static void Main(string[] args, Comparison<Book> compareByTitle)
        {
            BooksContainer container = new BooksContainer();

            container.AddBook(new Book("Война и мир", "Толстой", "Эксмо"));
            container.AddBook(new Book("Преступление и наказание", "Достоевский", "Азбука"));
            container.AddBook(new Book("Мастер и Маргарита", "Булгаков", "Советская Россия"));

            Console.WriteLine("Исходный список книг:");
            container.PrintBooks();

            Console.WriteLine("\nСортируем книги по названию:");
            container.SortBooks(CompareByTitle);
            container.PrintBooks();

            Console.WriteLine("\nСортируем книги по автору:");
            container.SortBooks(CompareByAuthor);
            container.PrintBooks();

            Console.WriteLine("\nСортируем книги по издательству:");
            container.SortBooks(CompareByPublisher);
            container.PrintBooks();
        }

        // Делегаты для сравнения книг
        delegate int Comparison<Book>(Book book1, Book book2);

        static Comparison<Book> CompareByTitle = delegate (Book book1, Book book2)
        {
            return String.Compare(book1.Title, book2.Title);
        };

        static Comparison<Book> CompareByAuthor = delegate (Book book1, Book book2)
        {
            return String.Compare(book1.Author, book2.Author);
        };

        static Comparison<Book> CompareByPublisher = delegate (Book book1, Book book2)
        {
            return String.Compare(book1.Publisher, book2.Publisher);
        };
    }
}