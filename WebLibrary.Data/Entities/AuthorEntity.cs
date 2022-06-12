using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Data.Entities
{
    public class AuthorEntity : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();
    }
}
