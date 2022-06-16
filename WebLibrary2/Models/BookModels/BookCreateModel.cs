using System.ComponentModel.DataAnnotations;
using WebLibrary.Web.Models.AuthorModels;
using WebLibrary.Web.Models.GenreModels;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web.Models.BookModels
{
    public class BookCreateModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be more than 2 letters")]
        public string Title { get; set; }

        public Guid AuthorId { get; set; }

        public List<AuthorViewModel>? Authors { get; set; }

        public Guid PublisherId { get; set; }

        public List<PublisherViewModel>? Publishers { get; set; }

        public Guid GenreId { get; set; }

        public List<GenreCreateModel>? Genres { get; set; }
    }
}
