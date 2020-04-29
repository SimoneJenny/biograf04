using System;
using System.Collections.Generic;

namespace UserForTest
{

    public class Users
    {
        public  Users()
        {
            //intialiserer object i en valid tilstand
        }
        public Users(int UsersId)
        {
            UsersId = UsersId;
        }
        public int UsersId { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mailAddress { get; set; }

        public string Fullname
        {
            get
            {
                //sådan undgår du at der kommer komma med ud når vi kalder på denne
                string fullname = Lastname;
                if (!string.IsNullOrWhiteSpace(firstname))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += firstname;
                }
                return fullname;
            }
        }
        public static int InstanceCount { get; set; }
        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(mailAddress)) isValid = false;

            return isValid;
        }
        //public Users Retrieve(int Userid) //Henter 1 user
        //{
        //    return new Users();
        //}
        public List<Users>Retrieve()
        {
            return new List<Users>();
        }
        //public bool save()
        //{
        //    return true;
        //}
        public bool Validates()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(mailAddress)) isValid = false;
            return isValid;
        }
    }
}
