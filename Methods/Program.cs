using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MEthods which is useful for coding because it is repeatable
            //Do not repeat yourself! (Dry)-Clean Code-Best Practice

            

           // String fruits = new String[] { }; // we can not write the int variables that's why we need to use classes

            Product product1 = new Product(); //this is class example and we have to execute it.
            Product product2 = new Product();


            product1.Name= "Apple";
            product1.Price= 15;
            product1.Description = "Apple of Amasya";

            product2.Name = "Strawberry"; 
            product2.Price = 20;
            product2.Description = "High Quality Fruit";

            Product[] product= new Product[] { product1, product2 }; //Now we can create the Product Array. 

            
            foreach (Product products in product) // products=alias , in product we are looping the this array,  
            {                                     //Product =which class we are working  
                Console.WriteLine("Product Name = " +products.Name);
                Console.WriteLine( "Product Price = " + products.Price);
                Console.WriteLine( "Product Description= " + products.Description);
                Console.WriteLine("-------------------------------------------------------");
             
            
            }
            Console.WriteLine("--------Methods------");

            BasketManager basketManager = new BasketManager(); //this one is instance

            basketManager.Add(product1);
            basketManager.Add(product2);  //we can use different page.It means reusablity

            //encapsulation

            basketManager.Add2("Pear","Green Pear",12,10);
            basketManager.Add2("Apple", "Green Aplle", 12,9);
            basketManager.Add2("Watermelon", "Watermelon of Adna", 12,8);








        }
    }
}
