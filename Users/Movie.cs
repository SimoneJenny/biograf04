using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(int movieId)
        { movieId = movieId; }

        public int MovieId { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public string Runtime { get; set; }
        public string Rating { get; set; }
        public string MainActors { get; set; }
        public string Theater { get; set; }
        public string Genrenumber { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Tittle == null) isValid = false;
            return isValid;
        }
    }
}
