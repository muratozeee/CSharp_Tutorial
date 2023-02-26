namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CustomerManager customerManager= new CustomerManager(); //we create the example to CustomerManager Class to operations.
            //Classes is created Pascal Case
            //But examples in the Main Class using camelCase
            customerManager.Add();     //when we use customerManager,Methods is coming directly to use.
            customerManager.Update();

           ProductManager productManager= new ProductManager(); // we created the new examples to class.And We are doing operations about product.
            productManager.Add();    //We are calling operations like this.
            productManager.Update();



            Customer customer1= new Customer() { Id=2,Name="Fuat",City="Istanbul"}; // we can write this type
            
            
            Customer customer2 = new Customer();// or this type we can defined the properties for customers
            customer2.Id=2;
            customer2.Name="Faruk"; //when we add information then set block is working.
            customer2.City = "Istanbul";

            //when we want to reach some information to show in display

            Console.WriteLine(customer2.Name); //We we take the information then get block is working.

           


        }
        class CustomerManager //When  we use the class we have to create the example to Customer Manager.
            
        {
            //We can write the methods about Customer in the class
            public void Add()
            {
                Console.WriteLine("Customer was Added..!"); //we added the method about custormer in CustomerManager Class.
            }
            public void Update()
            {
                Console.WriteLine("Customer was Updated..!");
            }

           

           
           
        }
        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Product was Added..!");
            }
            public void Update()
            {
                Console.WriteLine("Product was Updated..!");
            }
        }
    }
}