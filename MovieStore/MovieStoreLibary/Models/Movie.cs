using MovieStoreLibary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibary.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }
        
        public Movie() { }

        public Movie (string title, string description, int year, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }

        public void SetPrice()
        {
            Random number = new Random();
            if(Year < 2000)
            {
                Price = number.Next(100, 200);
                Console.WriteLine($"{Price}");
            } else if (Year > 2000 && Year < 2010)
            {
                Price = number.Next(200, 300);
                Console.WriteLine($"{Price}");
            }
            else
            {
                Price = number.Next(300, 500);
                Console.WriteLine($"{Price}");
            }
        }
    }
}
