using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Web.Models.AuthorModels
{
    public class AuthorCreateModel
    {
        public Guid id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be more than 2 letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be more than 2 letters")]
        public string LastName { get; set; }
    }
}
