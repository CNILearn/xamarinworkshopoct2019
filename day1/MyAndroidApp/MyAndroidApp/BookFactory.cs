using System.Collections.Generic;

namespace MyAndroidApp
{
    public class BookFactory
    {
        private readonly List<Book> _books = new List<Book>()
        {
            new Book {Title = "Professional C# 7", Publisher = "Wrox Press"},
            new Book { Title = "Enterprise Services", Publisher = "AWL"}
        };

        public IEnumerable<Book> GetBooks() => _books;
    }
}