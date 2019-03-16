using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkShop
{
    public static class OrderByGroupByOperators
    {
        public static void FirstSample()
        {
            //You can Orderby the collection for an element and create a orderedCollection
            List<Movie> movies = DataGeneration.CreateMovies();

            IOrderedEnumerable<Movie> moviesOrderedByGenre = movies.OrderBy(x => x.Genre);

            //Elements it's ordered by Genre

            foreach(var movieOrdered in moviesOrderedByGenre)
            {
                Console.WriteLine(movieOrdered);
            }
        }

        public static void SecondSample()
        {
            //We can group elements by an element from our collection

            List<Movie> movies = DataGeneration.CreateMovies();

            //The collection have a Key (In this case it's Genre) and a values that it's a collection with every movie order by Genre.
            
            IEnumerable<IGrouping<GenreEnum,Movie>> moviesGroupByGenre =  movies.GroupBy(x => x.Genre);

            foreach(var orderElements in moviesGroupByGenre)
            {
                //There a Key and Values inside it's collected in a Collection
                Console.WriteLine(orderElements.Key);
                Console.WriteLine(orderElements.Count());
            }
        }

        public static void FirstExercise()
        {
            //Movies Orderby duration
            var moviesOrdered = DataGeneration.CreateMovies().OrderBy(x => x.Duration);
        }

        public static void SecondExercise()
        {
            //Take all actors from collection and GroupBy by Age.
            var actorsByAge = DataGeneration.CreateMovies().SelectMany(x => x.Actors).GroupBy(x => x.Age);
        }

        public static void ThirdExercise()
        {
            //Take all actors Orderby inverse and GroupBy by sex
            var sexActors = DataGeneration.CreateMovies().SelectMany(x => x.Actors)
                .OrderBy(x => x.Name)
                .GroupBy(x => x.Sex);
        }
    }
}
