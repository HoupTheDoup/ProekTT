namespace WebLibrary.Data.Entities
{
    public class AuthorEntity : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();
    }
}
