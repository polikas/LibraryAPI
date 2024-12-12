using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;
using LibraryAPI.Repositories;


namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _repository = new();

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _repository.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _repository.GetBookById(id);
            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _repository.AddBook(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            if (id != book.Id) return BadRequest();

            _repository.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _repository.DeleteBook(id);
            return NoContent();
        }
    }
}
