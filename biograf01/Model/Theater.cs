using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class Theater
    {
        public int TheaterId { get; set; }
        //public int seat { get; set; }
        //public int row { get; set; }
        public IList<TheaterSeats> Theaters { get; set; } 
    }
}
