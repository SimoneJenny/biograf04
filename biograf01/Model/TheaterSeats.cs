using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class TheaterSeats
    {
        public int SeatId { get; set; }
        public seats seat { get; set; }
        public int TheaterId { get; set; }
        public Theater theater { get; set; }
    }
}
