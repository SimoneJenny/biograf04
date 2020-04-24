using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class Users
    {
        public int usersId { get; set; } //skal ligne klasse...//primary key
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mailAddress { get; set; }
        public int ZipCodeId { get; set; }
        //public ZipCode Zipcode { get; set; } //en user til en zipcod //FK
        public virtual IList<UserZipCode> UserZipCode { get; set; } 
    }
}

