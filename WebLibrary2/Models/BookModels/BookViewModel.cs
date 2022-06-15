namespace WebLibrary.Web.Models.Books
{

    public class BookViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public Guid AuthorId { get; set; }

        public string PublisherName { get; set; }

        public Guid PublisherId { get; set; }

        public string GenreName { get; set; }

        public Guid GenreId { get; set; }
    }
}
