using System.ComponentModel;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICustomerDal[] customers = new ICustomerDal[3]  //we defined the 2 databaser server with array 
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
                
              
            };

            foreach (var customerDal in customers)
            {
                customerDal.Add();
               
            }







          //PersonManeger personManeger= new PersonManeger();

          //  IPerson person=new Student(); //this code not working in main class. Because interfaces can not new 

          //  Customer customer= new Customer() {Id=52,FirstName="Murat",LastName="Oz",Address="Istanbul" };

          //  Student student= new Student() {Id=10,FirstName="Faruk",LastName="Oz",Department="Electrical & Electronics Engineer" };
          //  personManeger.Add(customer);
          //  personManeger.Add(student);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleServerCustomerDal());



          
            
        }
        interface IPerson
        {

            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }



        }

        class Customer : IPerson
        {
            //these one is concrete object
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //Also we can add just for customer properties.
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //Also we can add just for student properties.
            public string Department { get; set; }
        }
        class PersonManeger
        {

            public void Add(IPerson person) {

                Console.WriteLine(person.FirstName);
          
            
            }
        }


    }
}