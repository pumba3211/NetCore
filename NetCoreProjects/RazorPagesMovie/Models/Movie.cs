using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { set; get; }
        public string Title { set; get; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { set; get; }
        public string Genre { set; get; }

        public decimal Price { set; get; }
    }
}
