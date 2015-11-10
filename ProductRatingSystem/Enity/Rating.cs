using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRatingSystem.Enity
{
    class Rating
    {
        public int Rating;
        public string Username;
        public string RateDescription;
        public int RatingID;

        public Rating(int rating, string username, string ratedescription, int ratingid)
        {
            Rating = rating;
            Username = username;
            RateDescription = ratedescription;
            RatingID = ratingid;

        }






    }
}
