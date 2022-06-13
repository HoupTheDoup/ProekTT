using AutoMapper;
using WebLibrary.Data.Entities;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
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
            AuthorEntity author = _dbContext.Authors.FirstOrDefault(a => a.Id == id);
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
            _dbContext.Update(_mapper.Map<AuthorEntity>(author));
            _dbContext.SaveChanges();

            return author.Id;
        }
        public List<AuthorDto> GetAll()
        {
            var authors = _dbContext.Authors.ToList();
            return _mapper.Map<List<AuthorDto>>(authors);
        }

     /*   public string? GetAuthorName(Guid id)
        {
            var author = _dbContext.Authors.FirstOrDefault(a => a.Id == id);
            return $"{author.FirstName} {author.LastName}";
        }
     */
    }
}
