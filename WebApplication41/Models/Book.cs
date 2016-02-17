using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication41.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string Author { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        // Navigation property
        public Category Category{ get; set; }
    }
}