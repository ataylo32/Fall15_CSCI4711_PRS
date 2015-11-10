using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRatingSystem.Enity
{
    class Rating
    {
        public int Ratings;
        public string Username;
        public string RateDescription;
        public int RatingID;

        public Rating(int ratings, string username, string ratedescription, int ratingid)
        {
            Ratings = ratings;
            Username = username;
            RateDescription = ratedescription;
            RatingID = ratingid;

        }






    }
}
