using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class GenreRepository
    {
        public Genre Retrive(int GenreId)
        {
            Genre g = new Genre(GenreId);
            if (GenreId == 1)
            {
                g.GenreId = 1;
            }
            return g;
        }
        public bool Save(Genre genre)
        {
            return true;
        }
    }
}
