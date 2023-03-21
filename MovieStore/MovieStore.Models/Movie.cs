using MovieStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenres Genre { get; set; }
        private double Price { get; set; }
    }
}
