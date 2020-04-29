using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class Product
    {
        public Product()
        {

        }

        //overload contsructor, kan have samme navn men har forskellige krav
         public Product(int productId)
         {
            productId = productId;
         }

        public decimal? currentPrice { get; set; }
        public string productDescription { get; set; }
        public int productId { get; set; }
        public string ProductName { get; set; }

        //public Product Retrive(int productId)
        //{ return new Product(); }

        //public bool save()
        //{ return true; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (currentPrice == null) isValid = false;
            return isValid;
        }


    }
}
