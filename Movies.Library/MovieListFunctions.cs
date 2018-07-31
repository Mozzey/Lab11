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
                this.DisplayHorrorMovies(movieList, validOption);
            }
            else if (validOption == 2)
            {
                this.DisplayAnimatedMovies(movieList, validOption);
            }
            else if (validOption == 3)
            {
                this.DisplaySciFiMovies(movieList, validOption);
            }
            else if (validOption == 4)
            {
                this.DisplayDramaMovies(movieList, validOption);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter and option from the menu.");
                MovieCategoryDisplayList(movieList, validOption);
            }
        }
      public void DisplayDramaMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 4 && movie.GetCategory().ToLower() == "drama")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplaySciFiMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 3 && movie.GetCategory().ToLower() == "scifi")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplayAnimatedMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 2 && movie.GetCategory().ToLower() == "animated")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
      public void DisplayHorrorMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
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
