using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        public Guid CreateAuthor(AuthorDto book);

        public Guid UpdateAuthor(AuthorDto book);

        public void DeleteAuthor(Guid id);

        public AuthorDto GetAuthorById(Guid id);

        public List<AuthorDto> GetAll();

        public string GetAuthorName(Guid id);
    }
}
