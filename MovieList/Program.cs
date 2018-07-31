using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Library;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance of MovieList
            var movieList = new MovieListFunctions();
            ////////////////////////////////////////////////
            ///////////  TEST MOVIES ///////////////////////
            var starWars = new SciFi("Star Wars");
            var pokemon = new Animated("Pokemon");
            var it = new Horror("IT");
            var scream = new Horror("Scream");
            var incredibles = new Animated("Incredibles");
            var zootopia = new Animated("Zootopia");
            var serenity = new SciFi("Serenity");
            var theMatrix = new SciFi("The Matrix");
            var fightClub = new Drama("Fight Club");
            var seven = new Drama("Seven");
            ////////////////////////////////////////////////
            ///////// TEST LIST OF MOVIES /////////////////
            movieList.Add(starWars);
            movieList.Add(pokemon);
            movieList.Add(it);
            movieList.Add(scream);
            movieList.Add(incredibles);
            movieList.Add(zootopia);
            movieList.Add(serenity);
            movieList.Add(theMatrix);
            movieList.Add(fightClub);
            movieList.Add(seven);
            //////////////////////////////////////////////////
            // Sort the movie list alphabetically
            movieList.Sort((a, b) => a.GetTitle().CompareTo(b.GetTitle()));
            bool isRunning = true;
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 10 movies in this list.");
                movieList.ListMovieCategories();
                Console.Write("What category are you interested in?");
                var category = Console.ReadLine();
                if (int.TryParse(category, out int validOption) && validOption > 0 && validOption < 5)
                {
                    movieList.MovieCategoryDisplayList(movieList, validOption);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter and option from the menu.");
                    movieList.ListMovieCategories();
                }
                if (!PlayAgain())
                {
                    Console.WriteLine("Have a nice day!");
                    isRunning = false;
                }
                
            }
        }
        private static bool PlayAgain()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Would you like to look up another movie by category? (y/n)");    
            var runAgain = Console.ReadLine().ToLower();
            if (runAgain.StartsWith("y"))
            {
                return true;
            }
            else if (runAgain.StartsWith("n"))
            {
                return false;
            }
            else
            {
                return PlayAgain();
            }
        }
        
    }
}
