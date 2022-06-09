namespace WebLibrary.Data.Entities
{
    public class PublisherEntity : BaseEntity
    {
        public string Name { get; set; }

        public string YearOfPublshing { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new HashSet<BookEntity>();



    }
}
