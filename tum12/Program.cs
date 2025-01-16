using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tum12
{
    internal class Program
    {
        static void Main(string[] args) 
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

        
        static Comparison<Book> CompareByTitle = (book1, book2) => String.Compare(book1.Title, book2.Title);
        static Comparison<Book> CompareByAuthor = (book1, book2) => String.Compare(book1.Author, book2.Author);
        static Comparison<Book> CompareByPublisher = (book1, book2) => String.Compare(book1.Publisher, book2.Publisher);
    }
}