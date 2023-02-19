namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //we can use this method to dataBase number.
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product {Id =2,CategoryId=5,UnitInStock=5,ProductName="Pencil",UnitPrice=35}; // Also We can write like this type
            //case sensitive
            //Stack                              //Heap memory 
            ProductManager productManager = new ProductManager();
            // this one is calling as a Instance Creation

             productManager.Add(product1); //product1 is  defined in the Add funtion,and it is going ProductManager Class.Lets Check.

            Console.WriteLine(product1.ProductName);

          
           


            
        

            







                



        }
    }
}