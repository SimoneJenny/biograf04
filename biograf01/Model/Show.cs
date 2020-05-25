using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class Show
    {
        public int showId { get; set; }
        public Movie movie { get; set; }

        //public Theater theater { get; set; }
        public DateTime runtime { get; set; } 
    }
}
