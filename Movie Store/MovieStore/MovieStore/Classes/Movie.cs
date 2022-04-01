using MovieStore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        GenreEnum Genre { get; set; }
        private double Price;
        public void SetPrice()
        {
            Random RandomPrice = new Random();
            if (Year < 2000)
            {
                Price = RandomPrice.Next(100,200);
            }
            if (Year >= 2000 && Year < 2010)
            {
                Price = RandomPrice.Next(200, 300);
            }
            if (Year > 2010)
            {
                Price = RandomPrice.Next(300, 500);
            }
        }
    }
}
