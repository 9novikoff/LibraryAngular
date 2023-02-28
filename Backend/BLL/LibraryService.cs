using LibraryAngular.Backend.DLL;
using LibraryAngular.Backend.Models;

namespace LibraryAngular.Backend.BLL
{
    public class LibraryService
    {
        private readonly LibraryRepository _repository;

        public LibraryService(LibraryRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }


        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public List<Book> GetTopBooks()
        {
            const int size = 10;
            var topBooks = _repository.GetAllBooks().Where(b => b.ReviewsNumber > 10)
                .OrderByDescending(b => b.Rating)
                .Take(size).ToList();

            return topBooks;
        }

    }
}