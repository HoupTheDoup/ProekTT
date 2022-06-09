namespace WebLibrary.Data.Entities
{
    public class BookEntity : BaseEntity
    {
        public string Name { get; set; }

        public Guid AuthorId { get; set; }

        public virtual AuthorEntity Author { get; set; }

        public Guid PublisherId { get; set; }

        public virtual PublisherEntity Publisher { get; set; }

        public ICollection<GenreEntity> Genres { get; set; } = new HashSet<GenreEntity>();


    }
}
