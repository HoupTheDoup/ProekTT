using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Domain.Dtos
{
    public class AuthorDto : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string YearOfPublshing { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
