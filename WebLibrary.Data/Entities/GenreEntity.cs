namespace WebLibrary.Data.Entities
{
    public class GenreEntity : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();





    }
}
