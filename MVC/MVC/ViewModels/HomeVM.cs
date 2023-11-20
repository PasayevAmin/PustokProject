using MVC.Models;

namespace MVC.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }
        public List<Future> Futures { get; set; }
        public List<Book> Books { get; set; }
        public List<BookImage> bookImages { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }




    }
}
