using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class MovieRepository
    {
        public Movie Retrive(int MovieID)
        {
            Movie m = new Movie(MovieID);
            if (MovieID == 1)
            {
                m.Tittle = "Dødens gab";
                m.Theater = "Palads";
                m.Rating = "3 stjerner";
            }
            return m;
        }
        public bool Save(Movie movie)
        {
            return true;
        }
}   }

  