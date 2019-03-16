using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkShop
{
    public static class SelectLinqOperator
    {
        public static void FirstSample()
        {
            //Convert a bunch of data in another type

            List<Movie> movies = DataGeneration.CreateMovies();

            //We have the movies. Take only the Name from Movies

            IEnumerable<string> moviesName = movies.Select(x => x.Name);

            //The lambda it's x => x.Name that express a String return

            foreach(var name in moviesName)
            {
                Console.WriteLine(name);
            }                        
        }

        public static void SecondSample()
        {
            List<Movie> movies = DataGeneration.CreateMovies();

            //We can create to another class too.

            IEnumerable<Tuple<string, TimeSpan>> nameAndDurationMovies = movies.Select(x => new Tuple<string, TimeSpan>(x.Name, x.Duration));

            //In this case we create in Tuple<string, TimeSpan>>

            foreach(var elem in nameAndDurationMovies)
            {
                Console.WriteLine($"{elem.Item1} {elem.Item2}");
            }
        }

        public static void ThirdSample()
        {
            List<Movie> movies = DataGeneration.CreateMovies();

            //We can create a flat collection from another in this case use the SelectMany Linq operator

            IEnumerable<Actor> actors = movies.SelectMany(x => x.Actors);

            foreach(var actor in actors)
            {
                Console.WriteLine(actor);
            }
        }

        public static void FirstExercise()
        {
            //Convert TimeSpan from movies to Minutes duration.

            var movies = DataGeneration.CreateMovies();

            var durationMovies = movies.Select(x => x.Duration);
        }

        public static void SecondExercise()
        {
            //Convert Movies and take only the Name of actors

            var movies = DataGeneration.CreateMovies();

            var nameOfActors = movies.SelectMany(x => x.Actors).Select(x => x.Name);
        }

        public static void ThirdExercise()
        {
            //Create a new collection with Name of Movie and collection Actors name.

            var movies = DataGeneration.CreateMovies();

            var movieAndActors = movies.Select(x => new Tuple<string, List<Actor>>(x.Name, x.Actors));

        }

       
    }
}
