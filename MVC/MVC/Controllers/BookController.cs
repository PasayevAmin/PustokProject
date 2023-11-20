using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.DAL;
using MVC.Models;
using MVC.ViewModels;
using System;

namespace MVC.Controllers
{
    public class BookController : Controller
    {
       
            private readonly PustokDbContext _context;

        public BookController(PustokDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            Book book = _context.Books
                .Include(x => x.Author)
                .Include(x => x.Genre)
                .Include(x => x.BookImages)
                .Include(x=>x.BookTags)
                .ThenInclude(x=>x.Tags)
                .FirstOrDefault(x => x.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            List<Book> relatedbooks = _context.Books.Where(x => x.GenreId == book.GenreId)
                .Include(x=>x.Genre)
                .Include(x=>x.Author)
                .Include(x=>x.BookImages)
                .ToList();
                
       

           DetailsVM detailVM = new DetailsVM
         {
               Book=book,
               RelatedBooks=relatedbooks
               

          };
            return View(detailVM);
        }
         
        }
    }

