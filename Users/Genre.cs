using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class Genre
    {
        public Genre()
        {

        }

        public Genre(int GenreId)
        { GenreId = GenreId; }

        public int GenreId { get; set; }

        public string Genres { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Genres == null) isValid = false;
            return isValid;
        }
    }
}
