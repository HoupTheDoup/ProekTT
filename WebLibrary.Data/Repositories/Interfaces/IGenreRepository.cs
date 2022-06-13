using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        public Guid CreateGenre(GenreDto book);

        public void DeleteGenre(Guid id);

        public GenreDto GetGenreById(Guid id);

        public List<GenreDto> GetAll();
    }
}
