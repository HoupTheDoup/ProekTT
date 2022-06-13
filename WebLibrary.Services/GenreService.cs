using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;

namespace WebLibrary.Services
{
    public class GenreService : IGenreService
    {
        protected readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public Guid CreateGenre(GenreDto genre) => _genreRepository.CreateGenre(genre);

        public void DeleteGenre(Guid id) => _genreRepository.DeleteGenre(id);

        public GenreDto GetGenreById(Guid id) => _genreRepository.GetGenreById(id);

        public List<GenreDto> GetAll() => _genreRepository.GetAll();
    }
}
