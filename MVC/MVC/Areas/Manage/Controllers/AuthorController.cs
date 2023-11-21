using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.DAL;
using MVC.Models;

namespace MVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AuthorController : Controller
    {

        public readonly PustokDbContext _context;

        public AuthorController(PustokDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Author> authors = _context.Authors.Include(x=>x.Books).ToList();

            return View();
        }
    }
}
