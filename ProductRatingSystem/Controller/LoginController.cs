using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductRatingSystem.Enity;

namespace ProductRatingSystem.Controller
{
    class LoginController : Controller
    {

        string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ProductRatingSystem.mdf;Integrated Security=True";



        public bool Login(string name, string password)
        {
            List<User> Useer = new List<User>();
            using(SqlConnection mydbconn = new SqlConnection(connection))
            {
                mydbconn.Open();

                using( SqlCommand command = new SqlCommand("SELECT * FROM Username WHERE Username="+"'"+name+"'",mydbconn  ))
                {
                    SqlDataReader reader = command.ExecuteReader();




                }


            }
            return true;
        }


    }
}
