﻿namespace MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<BookImage> BookImages { get; set; }
        public List<BookTags> BookTags { get; set; }



    }
}
