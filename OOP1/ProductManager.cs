using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager // when we see the MAnager Or Service Name,
      // it has a operation Class abour product or something to CRUD Operation
    {
        public void Add(Product product)   //Product is defined as a product.but product1 is coming we will calling as product.
        {
            Console.WriteLine(product.ProductName+ " Eklendi");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" is Update");

        }
     


    }
}
