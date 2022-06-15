using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Web.Models.GenreModels
{
    public class GenreCreateModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
