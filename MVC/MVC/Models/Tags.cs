namespace MVC.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookTags> BookTags { get; set; }
    }
}
