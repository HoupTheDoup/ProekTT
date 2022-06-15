using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Web.Models.PublisherModels
{
    public class PublisherCreateModel
    {
        public Guid id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be more than 2 letters")]
        public string Name { get; set; }

        [Range(0,2022)]
        public string YearOfPublshing { get; set; }

        [Required]
        public string Address { get; set; }

        [Phone]
       // [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; set; }
    }
}
