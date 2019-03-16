using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkShop
{
    public static class DataGeneration
    {
        public static List<Movie> CreateMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Name = "Movie 1",
                    Actors = CreateActors(),
                    Duration = TimeSpan.FromMinutes(120),
                    Genre = GenreEnum.Action
                },
                new Movie()
                {
                    Name = "Movie 2",
                    Actors = CreateActors(),
                    Duration = TimeSpan.FromMinutes(150),
                    Genre = GenreEnum.Action
                },
                new Movie()
                {
                    Name = "Movie 3",
                    Actors = CreateActors(),
                    Duration = TimeSpan.FromMinutes(95),
                    Genre = GenreEnum.Romantic
                },
                new Movie()
                {
                    Name = "Movie 4",
                    Actors = CreateActors(),
                    Duration = TimeSpan.FromMinutes(75),
                    Genre = GenreEnum.Comedy
                }
            };
        }

        private static List<Actor> CreateActors()
        {
            return new List<Actor>()
            {
                new Actor()
                {
                    Name = "Actor 1",
                    Age = 20,
                    Sex = SexEnum.Male
                },
                new Actor()
                {
                    Name = "Actor 2",
                    Age = 25,
                    Sex = SexEnum.Female
                },
                new Actor()
                {
                    Name = "Actor 3",
                    Age = 40,
                    Sex = SexEnum.Female
                },
                new Actor()
                {
                    Name = "Actor 4",
                    Age = 18,
                    Sex = SexEnum.Male
                }
            };
        }
    }
}
