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
    public class GenreRepository : IGenreRepository
    {
        protected readonly WebLibraryDbContext _dbContext;
        protected readonly IMapper _mapper;

        public GenreRepository(WebLibraryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Guid CreateGenre(GenreDto genre)
        {
            GenreEntity entity = _mapper.Map<GenreEntity>(genre);
            entity.Id = Guid.NewGuid();

            _dbContext.Genres.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void DeleteGenre(Guid id)
        {
            GenreEntity genre = _dbContext.Genres.FirstOrDefault(a => a.Id == id);
            if (genre != null)
            {
                _dbContext.Remove(genre);
                _dbContext.SaveChanges();
            }
        }
        public GenreDto GetGenreById(Guid id)
        {
            var genre = _dbContext.Genres.FirstOrDefault(b => b.Id == id);
            return _mapper.Map<GenreDto>(genre);
        }

        public List<GenreDto> GetAll()
        {
            return _mapper.Map<List<GenreDto>>(_dbContext.Genres.ToList());
        }
    }
}
