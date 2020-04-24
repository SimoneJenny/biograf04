using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class UserZipCode
    {
        public int UserId { get; set; }
        public Users User { get; set; }
        public int ZipCode { get; set; }
        public ZipCode zipcode { get; set; }
    }
}
