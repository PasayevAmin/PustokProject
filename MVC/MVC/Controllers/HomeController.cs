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

        public async Task<IActionResult> Index()
        {
            List<Slide>slides=await _context.Slide.OrderBy(x=>x.Order).ToListAsync();
            List<Future> futures=await _context.Future.ToListAsync();

            List<Book> books =await _context.Books.Include(x=>x.Author)
                .Include(x=>x.Genre)
                .Include(x=>x.BookImages)
                .ToListAsync();


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
