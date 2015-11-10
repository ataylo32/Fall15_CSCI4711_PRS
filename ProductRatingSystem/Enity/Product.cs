using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRatingSystem.Enity
{
    class Product
    {
        public string Name;
        public string ProductDescription;
        public string Image;
        public int ProductID;

        public Product(string name, string productdescription, string image, int productid)
        {
            Name = name;
            ProductDescription = productdescription;
            Image = image;
            ProductID = productid;

        }

    }
}
