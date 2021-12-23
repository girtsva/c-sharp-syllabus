using System;
using System.Collections.Generic;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie01 = new Movie("Casino Royale", "Eon Productions", "PG­13");
            Movie movie02 = new Movie("Glass", "Buena Vista International", "PG­13");
            Movie movie03 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

            Movie[] movies = { movie01, movie02, movie03 };

            Movie[] filteredMovies = GetPG(movies);

            foreach (var filteredMovie in filteredMovies)
            {
                Console.WriteLine(filteredMovie.ShowMovie());
            }
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            List<Movie> filteredMovies = new List<Movie>();

            foreach (var movie in movies)
            {
                if (movie.Rating == "PG")
                {
                    filteredMovies.Add(movie);
                }
            }

            return filteredMovies.ToArray();
        }
    }
}
