using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Domain.Dtos
{
    public class PublisherDto : BaseDto
    {
        public string Name { get; set; }

        public string YearOfPublshing { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
