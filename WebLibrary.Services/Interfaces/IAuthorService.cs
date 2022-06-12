using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Services.Interfaces
{

        public interface IAuthorService
        {
            public Guid CreateAuthor(AuthorDto author);

            public Guid UpdateAuthor(AuthorDto author);

            public void DeleteAuthor(Guid id);

            public AuthorDto GetAuthorById(Guid id);

            public List<AuthorDto> GetAll();

            public string? GetAuthorName(Guid id);
    }
}
