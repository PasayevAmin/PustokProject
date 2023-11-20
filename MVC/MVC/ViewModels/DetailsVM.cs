using MVC.Models;

namespace MVC.ViewModels
{
    public class DetailsVM
    {
        public Book Book { get; set; }
        public List<Tags> Tags { get; set; }
        public List<BookTags> BookTags { get; set; }
        public List<Book> RelatedBooks { get; set; }
    }
}
