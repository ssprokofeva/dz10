using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tum12
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"Книга: \"{Title}\" by {Author}, издательство: {Publisher}";
        }
    }
}
