using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Entities;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories
{
    public class AuthorRepository
    {
        protected readonly WebLibraryDbContext _dbContext;
        protected readonly IMapper _mapper;

        public AuthorRepository(WebLibraryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Guid CreateAuthor(AuthorDto author)
        {
            AuthorEntity entity = _mapper.Map<AuthorEntity>(author);
            entity.Id = Guid.NewGuid();

            _dbContext.Authors.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void DeleteAuthor(Guid id)
        {
            AuthorEntity author = _mapper.Map<AuthorEntity>(GetAuthorById(id));
            if (author != null)
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
            }
        }
        public AuthorDto GetAuthorById(Guid id)
        {
            var author = _dbContext.Authors.FirstOrDefault(b => b.Id == id);
            return _mapper.Map<AuthorDto>(author);
        }

        public Guid UpdateAuthor(AuthorDto author)
        {
            _dbContext.Authors.Update(_mapper.Map<AuthorEntity>(author));
            _dbContext.SaveChanges();

            return author.Id;
        }
        public List<AuthorDto> GetAll()
        {
            return _mapper.Map<List<AuthorDto>>(_dbContext.Authors.ToList());
        }
    }
}
