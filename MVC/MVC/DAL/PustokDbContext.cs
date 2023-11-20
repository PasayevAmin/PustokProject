using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Net;

namespace MVC.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> options):base(options)
        {

        }
        public DbSet<Slide>  Slide{ get; set; }
        public DbSet<Future> Future { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<BookTags> BookTags { get; set; }




    }
}
