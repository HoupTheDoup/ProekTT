using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;

namespace WebLibrary.Services
{
    public class BookService : IBookService
    {
        protected readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Guid CreateBook(BookDto book) => _bookRepository.CreateBook(book);
        
        public void DeleteBook(Guid id) => _bookRepository.DeleteBook(id);

        public BookDto GetBookById(Guid id) => _bookRepository.GetBookById(id);

        public Guid UpdateBook(BookDto book) => _bookRepository.UpdateBook(book);

        public IEnumerable<T> GetAll<T>() => _bookRepository.GetAll<T>();

        public void DetailsBook(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
