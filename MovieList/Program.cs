using System;
using System.Collections.Generic;
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
            // USE ARRAYLIST AND GENERIC FOR LEARNING PURPOSES
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list");
            Console.WriteLine("What category are you interested in? ");
            foreach (var movie in listOfMovies)
            {
                
                Console.WriteLine($"{movie.GetTitle()} - {movie.GetCategory()}");
            }
            Console.ReadKey();
        }
    }
}
