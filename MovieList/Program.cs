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
            List<Movie> listOfMovies = new List<Movie>
            {
                starWars,
                pokemon,
                it,
                scream,
                incredibles,
                zootopia,
                serenity,
                theMatrix,
                fightClub,
                seven
            };
            //////////////////////////////////////////////////
            listOfMovies.Sort((a, b) => a.GetTitle().CompareTo(b.GetTitle()));
            while (true)
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 10 movies in this list.");
                var movieCategoryList = ListMovieCategories();
                var category = Console.ReadLine();
                foreach (var movie in listOfMovies)
                {

                    if (category == movie.GetCategory().ToLower())
                    {
                        Console.WriteLine($"{movie.GetTitle()} - {movie.GetCategory()}");
                    }
                }
                Console.Write("Would you like to look up another movie? (y/n)");
                var runAgain = Console.ReadLine().ToLower();
                if (!runAgain.StartsWith("y"))
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
            }
        }

        public static string ListMovieCategories()
        {
            var movieListAlphabetical = String.Format("{0,9}{1,11}{2,8}{3,8}",
                "1. Horror",
                "2. Animated",
                "3. SciFi",
                "4. Drama");
            return movieListAlphabetical;
        }

        
    }
}
