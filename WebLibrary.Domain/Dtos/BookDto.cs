using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Domain.Dtos
{
    public class BookDto : BaseDto
    {
        public string Title { get; set; }

        public string AuthorId { get; set; }

        public string PublisherId { get; set; }

        public string GenreId { get; set; }
    }
}
