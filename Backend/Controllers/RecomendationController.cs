using LibraryAngular.Backend.BLL;
using LibraryAngular.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAngular.Backend.Controllers
{
    [ApiController]
    [Route("api/recommended")]
    public class RecommendationController : ControllerBase
    {
        private readonly LibraryService _service;

        public RecommendationController(LibraryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _service.GetTopBooks();
        }

    }
}