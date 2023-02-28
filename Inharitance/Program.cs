using System.Reflection.Emit;

namespace Inharitance
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Customer customer= new Customer();

            customer.FirstName = "Murat";
            customer.LastName = "OZ";
            customer.Id = 1;
            customer.City = "Istanbul";


            //Also we can new Person because person is a class but IPerson is abstract class.that's why 
            Person[] persons= new Person[3] { 
            
            new Customer{FirstName="Murat",Id=3,LastName="OZ",City="Malatya"},
            new Student{FirstName="Faruk",Id = 5,LastName="cskn",Department="Electrical And Electronics"},
            new Person{FirstName="Suat",Id = 6,LastName="Stlms"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Id);
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine("----------------");
            }
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        
        }
   
        class Customer:Person  //We inharite the Person 
            //when we use the Customer we can reach the Person Information.Let's see the Main Class.
        {
            public string City { get; set; }

        }
        //We are taking information also Person Class

        interface IPerson1
        {

        }
        interface IPerson2
        {

        }
        class Student:Person,IPerson1,IPerson2 //we can use it

        {

            public string Department { get; set; }
        }

        
    }
}