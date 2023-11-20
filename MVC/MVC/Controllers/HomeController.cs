using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.DAL;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;
        public HomeController(PustokDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slide>slides= _context.Slide.OrderBy(x=>x.Order).ToList();
            List<Future> futures= _context.Future.ToList();

            List<Book> books = _context.Books.Include(x=>x.Author)
                .Include(x=>x.Genre)
                .Include(x=>x.BookImages)
                .ToList();


            HomeVM homeVM = new HomeVM
            {
            Futures=futures,
            Slides=slides,
            Books=books,
          
            };



            return View(homeVM);
        }
    }
}
