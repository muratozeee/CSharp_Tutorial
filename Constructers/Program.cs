using System.Diagnostics.CodeAnalysis;

namespace Constructers
{
    internal class Program
    {
        static void Main(string[] args)
        {
       Customer customer1= new Customer() {CustomerFirstId=1,CustomerName="Murat",CustomerSurname="OZ",City="Istanbul" }; //when we new it,constructor is working directly.

       Customer customer2 = new Customer(4, "Faruk", "Coskun", "Istanıbl"); //we can use like this.

            Customer customer3 = new Customer(); //Also we can use this type.
            customer3.CustomerName = "Suat";
            customer3.CustomerSurname = "stlms";
            customer3.CustomerFirstId = 4;
            customer3.City = "Istanbul";

            Console.WriteLine(customer2.CustomerName); //when we want to work this code we have to defined each other.


        }
    }

    class Customer
    {
        //defaul Constructor
        public Customer(int id,string firstname,string surname,string city) //we constructer not using void or something.just we are writring ctor+tap+tap
        {
            Console.WriteLine("Constructer is woking...");

            CustomerFirstId=id;
            CustomerName=firstname; //Customer parameters(FirstID,Name,Surname) are defined (id,firstname,surname) 
            CustomerSurname=surname;
            City=city;

        }
        public int CustomerFirstId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string City { get; set; }

        public Customer()
        {

        }
    }
}