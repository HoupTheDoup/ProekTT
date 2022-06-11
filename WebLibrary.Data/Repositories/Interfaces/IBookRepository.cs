using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Entities;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public Guid CreateBook(BookDto book);
        
        public Guid UpdateBook(BookDto book);

        public void DeleteBook(Guid id);

        public BookDto GetBookById(Guid id);

        public List<BookDto> GetAll(); 
    }
}
