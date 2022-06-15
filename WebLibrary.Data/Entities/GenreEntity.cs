using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Data.Entities
{
    public class GenreEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();
    }
}
