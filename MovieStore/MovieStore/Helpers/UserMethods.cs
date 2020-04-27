using MovieStoreLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Helpers
{
    public class UserMethods
    {
        public static Movie[] RentMovie (Movie[] arrayOfMovies)
        {
            Console.WriteLine("Please enter movie  title for rent");
            string movieTitle = Console.ReadLine();
            int indexToRemove = 0;
            foreach (var movie in arrayOfMovies)
            {
                if (movie.Title == movieTitle)
                {


                    indexToRemove = Array.IndexOf(arrayOfMovies, movie);

                }
            }
            // Ova ne znam sto pravi go vidov na stackoverflow ama raboti :D:D:D konecno
            arrayOfMovies = arrayOfMovies.Where((source, index) => index != indexToRemove).ToArray();

            return arrayOfMovies;
        }
    }
}
