using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Library
{
    public class MovieListFunctions : List<Movie>
    {
        public void MovieCategoryDisplayList(List<Movie> movieList, int validOption)
        {
            if (validOption == 1)
            {
                this.DisplayHorrorMovies(validOption);
            }
            else if (validOption == 2)
            {
                this.DisplayAnimatedMovies(validOption);
            }
            else if (validOption == 3)
            {
                this.DisplaySciFiMovies(validOption);
            }
            else if (validOption == 4)
            {
                this.DisplayDramaMovies(validOption);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter and option from the menu.");
                MovieCategoryDisplayList(movieList, validOption);
            }
        }
      public void DisplayDramaMovies(int category)
        {
            foreach (var movie in this)
            {
                if (category == 4 && movie.GetCategory().ToLower() == "drama")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplaySciFiMovies(int category)
        {
            foreach (var movie in this)
            {
                if (category == 3 && movie.GetCategory().ToLower() == "scifi")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplayAnimatedMovies(int category)
        {
            foreach (var movie in this)
            {
                if (category == 2 && movie.GetCategory().ToLower() == "animated")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplayHorrorMovies(int category)
        {
            foreach (var movie in this)
            {
                if (category == 1 && movie.GetCategory().ToLower() == "horror")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
        public void ListMovieCategories()
        {
            var movieListAlphabetical = String.Format("{0,9}\n{1,11}\n{2,8}\n{3,8}",
                "1. Horror",
                "2. Animated",
                "3. SciFi",
                "4. Drama");
            Console.WriteLine(movieListAlphabetical);
        }
    }
}
