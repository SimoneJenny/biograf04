using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class ZipCode
    {
        public int zipcodeId { get; set; } //primary Key
        public int Zipcode { get; set; }
        public string city { get; set; }
        public IList<UserZipCode> ZipCodes{get; set;}
    }
}
