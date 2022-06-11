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

        public string Author { get; set; }
    }
}
