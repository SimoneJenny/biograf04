using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class ProductRepository
    {
        //hent 1 produkt
        public Product Retrive(int productId)
        {
            Product product = new Product(productId);
            if (productId ==2)
            {
                product.ProductName = "ProductName";
                product.productDescription = "Description";
                product.currentPrice = 15.88M;
            }

            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
