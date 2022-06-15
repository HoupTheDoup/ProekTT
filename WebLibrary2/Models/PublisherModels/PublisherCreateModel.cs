using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Web.Models.PublisherModels
{
    public class PublisherCreateModel
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string YearOfPublshing { get; set; }

        public string Address { get; set; }

        [Phone]
       // [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; set; }
    }
}
