using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication41.Models
{
    public class BookDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string CategoryName { get; set; }
        public string Author { get; set; }
    }
}