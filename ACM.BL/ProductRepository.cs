using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();
            {
                product.ProductName = "snow";
                product.ProductDescription = "beautiful";
                product.CurrentPrice = 12;

            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
