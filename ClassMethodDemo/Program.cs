namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();    
            Customer customer4 = new Customer();
           

            customer1.Id = 145657;
            customer1.Name = "Murat";
            customer1.Surname = "OZ";
            customer1.Address = "Istannbul";

            customer2.Id = 145654;
            customer2.Name = "Suat";
            customer2.Surname = "Satılmıs";
            customer2.Address = "Istanbul";

            customer3.Id = 564754;
            customer3.Name = "Faruk";
            customer3.Surname = "Coskun";
            customer3.Address = "Istanbul";

            customer4.Id = 454748; ;
            customer4.Name = "Bayram";
            customer4.Surname = "Aslan";
            customer4.Address = "Istanbul";


            Customer[] customer =new Customer[] { customer1, customer2,customer3,customer4 };
            
            foreach (var customers in customer)
            {
                Console.WriteLine("ID = "+customers.Id);
                Console.WriteLine("Name = "+customers.Name);
                Console.WriteLine("Surname = "+customers.Surname);
                Console.WriteLine("Adress = "+customers.Address);
                Console.WriteLine("-------------------------------");

            }
            Console.WriteLine("Methods with CustomerManager");
            Console.WriteLine("*");

            CustomerManager customerManager=new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            Console.WriteLine("-----------------------------------------------Using Customer Manager");
            customerManager.Listed(145657, "Murat", "OZ", "Istanbul");
            customerManager.Listed(145654, "Suat", "Satılmıs", "Istanbul");
            customerManager.Listed(564754, "Faruk", "Coskun", "Istanbul");
            customerManager.Listed(454748, "Bayram", "Aslan", "Istanbul");

            customerManager.Remove(customer1);
            customerManager.Remove(customer2);
            customerManager.Remove(customer3);
            customerManager.Remove(customer4);
            

            customer4.Id = 775645; ;
            customer4.Name = "Kemal";
            customer4.Surname = "Oz";
            customer4.Address = "Eskişehir";
   

            customerManager.Update(customer4);


            Customer customer5=new Customer();
            customer5.Id = 775645; ;
            customer5.Name = "Kemal";
            customer5.Surname = "Oz";
            customer5.Address = "Eskişehir";


            customerManager.Add2(customer5);



      









        }
    }
}