using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class MovieGenre
    {
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int GenreId { get; set; }
        public Genre genre { get; set; }
    }
}
