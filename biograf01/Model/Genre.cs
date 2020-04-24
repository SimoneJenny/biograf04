using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required] //genre må ikke være null!!!
        public string Genres { get; set; }
        public IList<MovieGenre> Movie { get; set; } ///???

        //https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx

    }
}
