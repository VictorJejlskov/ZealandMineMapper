using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library105
{
    public class BookCatalog
    {
        private List<Book> _books { get; set; } = new List<Book>();

        public List<Book> GetBooks()
        {
            return _books;
        }

        public void AddBook(Book aBook)
        {
            _books.Add(aBook);
        }

        public Book LookUpBook(string isn)
        {
            if (string.IsNullOrWhiteSpace(isn)) throw new ArgumentNullException("ISN cannot be null or empty");
            Book bookFound = _books.Find(bo => bo.ISN.Equals(isn));
            if (bookFound == null) throw new ArgumentOutOfRangeException("No item");
            return bookFound;
        }

        public Book DeleteBook(string isn)
        {
            if (string.IsNullOrWhiteSpace(isn)) throw new ArgumentNullException();
            Book bookFound = _books.Find(bo => bo.ISN.Equals(isn));
            if (bookFound == null) throw new ArgumentOutOfRangeException("No such item");
            _books.Remove(bookFound);
            return bookFound;
        }
    }
}
