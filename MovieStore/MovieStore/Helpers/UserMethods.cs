using MovieStoreLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Helpers
{
    public class UserMethods
    {
        public static Movie[] RentMovie (Movie[] arrayOfMovies, User user)
        {
            Console.WriteLine("Please enter movie  title for rent");
            string movieTitle = Console.ReadLine();
            int indexToRemove = 0;
            bool searchCheck = false;
            while (!searchCheck)
            {
                foreach (var movie in arrayOfMovies)
                {
                    if (movie.Title == movieTitle)
                    {
                        user.RentedMovies = new Movie[] { movie }; // vaka go resiv i sega raboti :DDDD
                        indexToRemove = Array.IndexOf(arrayOfMovies, movie);
                        searchCheck = true;

                    }
                }
                if (!searchCheck)
                {
                    Console.WriteLine("We don't have that movie");
                    searchCheck = true;
                }
                // Ova ne znam sto pravi go vidov na stackoverflow ama raboti :D:D:D konecno
                arrayOfMovies = arrayOfMovies.Where((source, index) => index != indexToRemove).ToArray();
            }


            return arrayOfMovies;
        }
    }
}
