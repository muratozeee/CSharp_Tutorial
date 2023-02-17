using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        //naming Convention
        //syntax
        public void Add(Product product)  // it means we added the Product class to use Product information as a product which is alias.
        {
            Console.WriteLine(" Congralations We added the Basket! "+product.Name);
            Console.WriteLine("-----------");

 }
        public void Add2(String productName,String information,double price,int stockNum) {

            Console.WriteLine("Congralations we added the baskett! " + productName);
        }

    }
}
