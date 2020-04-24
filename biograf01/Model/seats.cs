using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class seats
    {
        public int seatsId { get; set; }
        public bool Avalible { get; set; }
        public int seat { get; set; }
        public int row { get; set; }
        public IList<TheaterSeats> Theatersseats { get; set; }
    }
}
