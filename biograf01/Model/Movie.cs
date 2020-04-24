using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    
    public class Movie
    {
        public int MovieId { get; set; }
        [Required] //må ikke være null!!!
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public string Runtime { get; set; }
        public string Rating { get; set; }
        public string MainActors { get; set; }
        public string Theater { get; set; }
        public string Genrenumber { get; set; }
        public virtual IList<MovieGenre> Moviegenre { get; set; }

    }
}
