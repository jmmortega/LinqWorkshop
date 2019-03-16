using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkShop
{
    public class Movie
    {
        public string Name { get; set; }

        public TimeSpan Duration { get; set; }

        public GenreEnum Genre { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
