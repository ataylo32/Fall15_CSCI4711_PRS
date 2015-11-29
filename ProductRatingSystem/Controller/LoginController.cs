using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductRatingSystem.Controller
{
    class LoginController : Controller
    {

        string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ProductRatingSystem.mdf;Integrated Security=True";



        public bool Login(string name, string password)
        {
            using(SqlConnection mydbconn = new SqlConnection(connection))
            {

            }
            return true;
        }


    }
}
