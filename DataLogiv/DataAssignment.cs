using BusinessEnitity.Models;
using System.Collections.Generic;

namespace DataLogic
{
    public class DataAssignment
    {

        public List<Product> ProductAssign()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Price = 100,
                    Quantity = 20
                },
                new Product
                {
                    ProductId = 2,
                    Price = 20,
                    Quantity = 50
                },
                new Product
                {
                    ProductId = 3,
                    Price = 50,
                    Quantity = 60
                }
            };
            return products;
        }

        public List<Size> SizeAssign()
        {
            List<Size> sizes = new List<Size>
            {
                new Size
                {
                    SizeId = 1,
                    ProductId = 1,
                    Quantity = 10
                },
                new Size
                {
                    SizeId = 2,
                    ProductId = 1,
                    Quantity = 20
                },
                new Size
                {
                    SizeId = 3,
                    ProductId = 2,
                    Quantity = 60
                },
                new Size
                {
                    SizeId = 4,
                    ProductId = 3,
                    Quantity = 60
                }
            };
            return sizes;
        }
    }
}
