using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Entities;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;


namespace WebLibrary.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected readonly WebLibraryDbContext _dbContext;
        protected readonly IMapper _mapper;
         
        public BookRepository(WebLibraryDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Guid CreateBook(BookDto book)
        {
            BookEntity entity = _mapper.Map<BookEntity>(book);
            entity.Id = Guid.NewGuid();

            _dbContext.Books.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void DeleteBook(Guid id)
        {
            BookEntity book = _mapper.Map<BookEntity>(GetBookById(id));
            if(book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }
        public BookDto GetBookById(Guid id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            return _mapper.Map<BookDto>(book);
        }

        public Guid UpdateBook(BookDto book)
        {
            _dbContext.Books.Update(_mapper.Map<BookEntity>(book));
            _dbContext.SaveChanges();

            return book.Id;
        }
        public List<BookDto> GetAll()
        {
            return _mapper.Map<List<BookDto>>(_dbContext.Books.ToList());
        }

    }
}
