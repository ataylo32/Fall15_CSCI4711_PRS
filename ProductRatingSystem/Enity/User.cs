using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRatingSystem.Enity
{
    class User
    {
        public string Username;
        public int UserID;
        public bool AdminRights;


        public User(string username, int userid, bool adminrights)
        {
            Username = username;
            UserID = userid;
            AdminRights = adminrights;

        }



    }
}
