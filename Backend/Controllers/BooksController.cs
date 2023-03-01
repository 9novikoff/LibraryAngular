using System.Formats.Asn1;
using LibraryAngular.Backend.BLL;
using LibraryAngular.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAngular.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryService _service;

        public BooksController(LibraryService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _service.GetAllBooks();
        }

        [HttpPost]
        public IActionResult Save(Book? book)
        {
            if (book == null)
                return NotFound();
            _service.AddBook(book);
            return Ok();
        }

    }
}