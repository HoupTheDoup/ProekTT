using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLibrary.Data.Entities
{
    [Table("Publishers")]
    public class PublisherEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string YearOfPublshing { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();



    }
}
