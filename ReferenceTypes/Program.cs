namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1=new Person();
            Person person2=new Person();
            person1.FirstName = "Murat";

            person2 = person1; //these ones are working as a reference type.That's why person2 has a person1's reference Number.
                               //when we change the person1.Person2 will change.Also  when Person2 change,person1 will change let's see.

            Console.WriteLine("Person2 First Name= "+person2.FirstName);

            person2.FirstName = "Suat"; //we changed the person2.Firstname at the same time person1.FirstName changed.

            Console.WriteLine("Person1 First Name= "+person1.FirstName);
            Console.WriteLine("Person2 First Name= "+person2.FirstName);

            Customer customer=new Customer();
            customer.FirstName = "Faruk";
            Employee employee=new Employee();

            employee.FirstName = "Veli";

            //customer = employee; we can not use this code because both different name to use . you can imagine (int) and (string) cannot equal each other.
            
            Person person3 = customer; //we can use this  code because customer inharite the Person that's why they can equal each other.
            Console.WriteLine(person3.FirstName);

            //also we can not reach the customer'Credit Number with person3.

            ((Customer)person3).CreditNum = "5452";  //we can reach creditnumber with person3 like this.//we are doing the boxing.
            customer.CreditNum = "444455522";

            Console.WriteLine(customer.CreditNum); 

            Console.WriteLine(((Customer)person3).CreditNum); //we can use with this method to CreditNum 

            PersonManager personManager = new PersonManager();

            personManager.Add(customer);
            personManager.Add(employee);


            


        }
    }

    class Person //base Class=Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

    }

    class Customer:Person  //we did the inheritance we can use the customer as a person. it means depending on base class.Customer is a Person at this time.
    {
        public string CreditNum { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNum { get; set; } 
    }
    class PersonManager
    {
        public void Add(Person person) //we can use Person,Customer and Employee classes because they inharite the Person.
        {
            Console.WriteLine(person.FirstName);

        }
    }
}