using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Services.Interfaces
{
    public interface IGenreService
    {
        public Guid CreateGenre(GenreDto author);

        public void DeleteGenre(Guid id);

        public GenreDto GetGenreById(Guid id);

        public List<GenreDto> GetAll();
    }
}
