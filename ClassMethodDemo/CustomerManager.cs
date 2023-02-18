using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is Added= " + customer.Name);

            Console.WriteLine("________________");

        }

        public void Remove(Customer customer) {
            Console.WriteLine("Id No=" + customer.Id + " Customer Name=" + customer.Name + " is Removed in the system...");

        }



        public void Listed(int customerId, String customerName, String customerSurname, String customerAdress) {



            Console.WriteLine("ID = " + customerId);
            Console.WriteLine("Name = " + customerName);
            Console.WriteLine("Surname = " + customerSurname);
            Console.WriteLine("Adress = " + customerAdress);
            Console.WriteLine("-------------------------------");


        }

        public void Update(params Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("");
                Console.WriteLine("ID = " + customers.Id);
                Console.WriteLine("Name = " + customers.Name);
                Console.WriteLine("Surname = " + customers.Surname);
                Console.WriteLine("Adress = " + customers.Address);
                Console.WriteLine("Customer is Updated..!");


            }

            }

        public void Add2(params Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("");
                Console.WriteLine("ID = " + customers.Id);
                Console.WriteLine("Name = " + customers.Name);
                Console.WriteLine("Surname = " + customers.Surname);
                Console.WriteLine("Adress = " + customers.Address);
                Console.WriteLine("Customer is Added With Params..!");


            }

        }







    }
}
