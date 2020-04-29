using System;
using System.Collections.Generic;
using System.Text;
using UserForTest;

namespace UserForTest
{
    public class UserRepository
    {
        //hent 1 user
        public Users Retrive(int UserId)
        {
            Users User = new Users(UserId);
            if (UserId ==1)
            {
                User.mailAddress = "myemail@live.dk";
                User.firstname = "Frode";
                User.lastname = "Nisse";
            }
            return User;
           
        }
        //lager User
        public bool Save(Users users)
        {
            return true;
        }
    }
}
