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
            bool isRunning = true;
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 10 movies in this list.");
                var movieCategoryList = ListMovieCategories();
                Console.WriteLine($"\n{movieCategoryList}");
                Console.Write("What category are you interested in?");
                var category = Console.ReadLine();
                if (int.TryParse(category, out int validOption) && (validOption > 0 && validOption < 5))
                {
                    switch (validOption)
                    {
                        case 1:
                            DisplayHorrorMovies(listOfMovies, validOption);
                            break;
                        case 2:
                            DisplayAnimatedMovies(listOfMovies, validOption);
                            break;
                        case 3:
                            DisplaySciFiMovies(listOfMovies, validOption);
                            break;
                        case 4:
                            DisplayDramaMovies(listOfMovies, validOption);
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter and option from the menu.");
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

        private static void DisplayDramaMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 4 && movie.GetCategory().ToLower() == "drama")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }

        private static void DisplaySciFiMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 3 && movie.GetCategory().ToLower() == "scifi")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }

        private static void DisplayAnimatedMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 2 && movie.GetCategory().ToLower() == "animated")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
        public static void DisplayHorrorMovies(List<Movie> listOfMovies, int category)
        {
            foreach (var movie in listOfMovies)
            {
                if (category == 1 && movie.GetCategory().ToLower() == "horror")
                {
                    Console.WriteLine($"{movie.GetTitle()}");
                }
            }
        }
        public static string ListMovieCategories()
        {
            var movieListAlphabetical = String.Format("{0,9}\n{1,11}\n{2,8}\n{3,8}",
                "1. Horror",
                "2. Animated",
                "3. SciFi",
                "4. Drama");
            return movieListAlphabetical;
        }

        
        
    }
}
