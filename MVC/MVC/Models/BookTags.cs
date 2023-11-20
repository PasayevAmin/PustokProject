namespace MVC.Models
{
    public class BookTags
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int TagsId { get; set; }
        public Tags Tags { get; set; }
    }
}
