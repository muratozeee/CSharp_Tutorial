namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          IndividualCustomer customer1= new IndividualCustomer();
            
            //individual Customer.
            customer1.Id = 1;
            customer1.CustomerNo = "12345"; //IndividualCustomer dont have customerno but it inharites Customer that's why it has a Customer no.
            customer1.CustomerName = "Murat";
            customer1.CustomerSurname = "OZ";
            customer1.CustomerTcNo = "123213123";

            CorporateCustomer customer2= new CorporateCustomer();
            
            //Turkcell

            customer2.Id = 2;
            customer2.CustomerNo = "4232323";
            customer2.CustomerCompany = "Turkcell";
            customer2.TaxNo = "45521";



            Customer customer3 = new IndividualCustomer();
            //Customer can have IndividualCustomers reference number and CorporateCustomers referencenumbers
            Customer customer4 = new CorporateCustomer();


            CustomerManager customerManager= new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            
            //we defined the Company but this one Reel person we are using but also Company is coming.

            //Reel Person, Company.



        }
    }
}