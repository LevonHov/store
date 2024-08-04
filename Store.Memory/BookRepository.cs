using System;
using System.Linq;

namespace Store.Memory

{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books =
        {
            new Book(1, "ISBN 12345-12345", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 12346-12346", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 12347-12347", "B. karenighan", "C Programming Language")
        };

        public Book[] GetAllByIsbm(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query)
                                   ||  book.Author.Contains(query))
                        .ToArray();
        }
    }
}
