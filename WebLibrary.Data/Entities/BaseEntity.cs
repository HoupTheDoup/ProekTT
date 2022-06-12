using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Data.Entities
{
    public class BaseEntity
    {

        [Key]
        public Guid Id { get; set; }
    }
}
