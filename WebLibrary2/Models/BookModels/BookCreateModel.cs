namespace WebLibrary.Web.Models.BookModels
{
    public class BookCreateModel
    {
        public string Title { get; set; }

        public Guid AuthorId { get; set; }

        public Guid PublisherId { get; set; }
    }
}
