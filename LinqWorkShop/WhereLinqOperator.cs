using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkShop
{
    public static class WhereLinqOperator
    {
        public static void FirstSample()
        {
            //We can filter and get a new collection with Where operator. 
            List<Movie> movies = DataGeneration.CreateMovies();

            //Always need to return a boolean in Lambda function 
            IEnumerable<Movie> actionMovies = movies.Where(x => x.Genre == GenreEnum.Action);

            foreach(var movie in actionMovies)
            {
                Console.WriteLine(movie.Name);
            }
        }

        public static void SecondSample()
        {
            List<Movie> movies = DataGeneration.CreateMovies();

            //We can use two or more Lambda operators concatenated.
            IEnumerable<Movie> resultMovies = movies.Where(x => x.Genre == GenreEnum.Action)
                                                    .Where(x => x.Duration >= TimeSpan.FromMinutes(80));


            //You can use the Where operator inside of a collection if there another collection
            IEnumerable<Movie> moviesWithActorOld15 = resultMovies.Where(x => x.Actors.Any(y => y.Age >= 15));

            Console.WriteLine(moviesWithActorOld15.Count());
        }

        public static void ThirdSample()
        {
            //Linq have a First and Last operators that allows take the first Element or the LastOperator from a collection
            List<Movie> movies = DataGeneration.CreateMovies();

            Movie firstMovie = movies.First();
            Movie lastMovie = movies.Last();

            //You can use Lambda like Where operator

            Movie firstMovieOfTerror = movies.First(x => x.Genre == GenreEnum.Terror);
            Movie lastMovieOfTerror = movies.Last(x => x.Genre == GenreEnum.Terror);

            //There and implementation Operator with OrDefault, that take the Default value. (Null in Class case)
            Movie firstMovieOfTerrorOrDefault = movies.FirstOrDefault();
            Movie lastMoviewOfTerrorOrDefault = movies.LastOrDefault();
        }

        public static void ForthSample()
        {
            //You can take or skip N elements from a collection to take that you want.
            //It's really useful when create a index.

            List<Movie> movies = DataGeneration.CreateMovies();

            IEnumerable<Movie> moviesSkipped = movies.Skip(2).Take(5);
        }

        public static void FirstExercise()
        {
            //Filter actions movies and get the last one
        }

        public static void SecondExercise()
        {
            //Filter comedy movies and Duration it's 90 minutes or more
        }

        public static void ThirdExercise()
        {
            //Take the first element or Default that have an actor that old 40 or more.
        }


    }
}
