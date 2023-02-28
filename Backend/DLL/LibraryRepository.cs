using LibraryAngular.Backend.Models;

namespace LibraryAngular.Backend.DLL
{
    public class LibraryRepository
    {
        private readonly List<Book> _mockContext;

        public LibraryRepository()
        {
            _mockContext = new List<Book>()
            {
                new Book(){ Id = 1, Title = "Don Quixote", Cover = "",
                    Content = "The plot revolves around the adventures of a member of the lowest nobility, an hidalgo from La Mancha named Alonso Quijano, who reads so many chivalric romances that he either loses or pretends to have lost his mind in order to become a knight-errant (caballero andante) to revive chivalry and serve his nation, under the name Don Quixote de la Mancha.",
                    Author = "Miguel de Cervantes", Genre = "Novel", Rating = 4.8M, ReviewsNumber = 1},
                new Book(){ Id = 1, Title = "Don Quixote", Cover = "",
                    Content = "The plot revolves around the adventures of a member of the lowest nobility, an hidalgo from La Mancha named Alonso Quijano, who reads so many chivalric romances that he either loses or pretends to have lost his mind in order to become a knight-errant (caballero andante) to revive chivalry and serve his nation, under the name Don Quixote de la Mancha.",
                    Author = "Miguel de Cervantes", Genre = "Novel", Rating = 4.8M, ReviewsNumber = 2},
                new Book(){ Id = 1, Title = "Don Quixote", Cover = "",
                    Content = "The plot revolves around the adventures of a member of the lowest nobility, an hidalgo from La Mancha named Alonso Quijano, who reads so many chivalric romances that he either loses or pretends to have lost his mind in order to become a knight-errant (caballero andante) to revive chivalry and serve his nation, under the name Don Quixote de la Mancha.",
                    Author = "Miguel de Cervantes", Genre = "Novel", Rating = 4.8M, ReviewsNumber = 3},
                new Book(){ Id = 1, Title = "Don Quixote", Cover = "",
                    Content = "The plot revolves around the adventures of a member of the lowest nobility, an hidalgo from La Mancha named Alonso Quijano, who reads so many chivalric romances that he either loses or pretends to have lost his mind in order to become a knight-errant (caballero andante) to revive chivalry and serve his nation, under the name Don Quixote de la Mancha.",
                    Author = "Miguel de Cervantes", Genre = "Novel", Rating = 4.8M, ReviewsNumber = 10},
                new Book(){ Id = 1, Title = "Don Quixote", Cover = "",
                    Content = "The plot revolves around the adventures of a member of the lowest nobility, an hidalgo from La Mancha named Alonso Quijano, who reads so many chivalric romances that he either loses or pretends to have lost his mind in order to become a knight-errant (caballero andante) to revive chivalry and serve his nation, under the name Don Quixote de la Mancha.",
                    Author = "Miguel de Cervantes", Genre = "Novel", Rating = 4.8M, ReviewsNumber = 120}
            };
        }

        public List<Book> GetAllBooks()
        {
            return _mockContext;
        }

        public Book GetBookById(int id)
        {
            return _mockContext.First(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _mockContext.Add(book);
        }

        public bool TryToDeleteBook(int id)
        {
            var book = _mockContext.First(b => b.Id == id);

            if (book == null)
                return false;

            _mockContext.Remove(book);
            return true;
        }
    }
}