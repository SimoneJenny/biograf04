using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class Theater
    {
        public int TheaterId { get; set; }
        public int theaternumbIds { get; set; }
        public int seat { get; set; }
        public int row { get; set; }
        public virtual IList<TheaterSeats> Theatersseats { get; set; } 
    }
}
