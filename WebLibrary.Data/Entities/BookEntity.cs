using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Data.Entities
{
    public class BookEntity : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public virtual AuthorEntity Author { get; set; }

        [Required]
        public Guid PublisherId { get; set; }

        public virtual PublisherEntity Publisher { get; set; }

        public ICollection<GenreEntity> Genres { get; set; } = new HashSet<GenreEntity>();


    }
}
