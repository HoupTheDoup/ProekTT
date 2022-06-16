using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Domain.Dtos
{
    public class BookWithListsDto : BookDto
    {
        public List<AuthorDto> Authors { get; set; }

        public List<PublisherDto> Publishers { get; set; }

        public List<GenreDto> Genres { get; set; }
    }
}
