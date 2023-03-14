namespace BTVN_B5_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
       /* public Book(int id, string title, string author, decimal? price, string description, string image, int? categoryId, Category category)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
            Description = description;
            Image = image;
            CategoryId = categoryId;
            Category = category;
        }*/

       /* public Book()
        {

        }*/

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Author { get; set; }

        public decimal? Price { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
