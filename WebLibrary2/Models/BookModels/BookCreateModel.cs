namespace WebLibrary.Web.Models.BookModels
{
    public class BookCreateModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid AuthorId { get; set; }

        public Guid PublisherId { get; set; }

        public Guid GenreId { get; set; }
    }
}
