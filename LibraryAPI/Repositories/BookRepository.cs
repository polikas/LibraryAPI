using LibraryAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAPI.Repositories
{
    public class BookRepository
    {
        private readonly List<Book> _books = new();

        public IEnumerable<Book> GetAllBooks() => _books;

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book) => _books.Add(book);
        
        public void UpdateBook(Book book)
        {
            var existingBook = GetBookById(book.Id);
            if (existingBook == null) return;

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.YearPublished = book.YearPublished;
        }

        public void DeleteBook(int id) => _books.RemoveAll(b => b.Id == id);
    }
}
