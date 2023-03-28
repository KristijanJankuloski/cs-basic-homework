using MovieStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenres Genre { get; set; }
        public bool IsAvalable { get; set; }
        private double Price { get; set; }

        public Movie(string title, string description, int year, MovieGenres genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            IsAvalable = true;
            SetPrice(Year);
        }

        public void SetPrice(int year)
        {
            Random random = new Random();
            if(year <= 2000)
            {
                Price = random.Next(100, 200);
            }
            else if(year > 2000 && year < 2010)
            {
                Price = random.Next(200, 300);
            }
            else
            {
                Price = random.Next(300, 500);
            }
        }
        public string GetShortInfo()
        {
            return $"{Title} - {Year} - {Genre} - {Price}";
        }
    }
}
