using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> id = new List<int>() {1,2,3,4,5,6};
            List<string>names = new List<string>() { "Murat","Suat","Faruk","Rıza","Hüseyin","Muzaffer"};
            List<string>surnames = new List<string>() {"OZ","stlms","cskn","oznk","hllogl","kal"};
            List<double> PhoneNumbers= new List<double>() {0521542241,210045224,545212,21212144,88554522,545211 };
            List<string> cities = new List<string>() { "Malatya","Sivas","Gümüshane","Rize","Hatay","Antalya"};
            List<string> types= new List<string>() {"Student", "Customer", "Police", "Teacher", "Doctor", "Customer" };
            CustomerManager customer = new CustomerManager();
            
            customer.StudentCreditRate = 1.75;
            customer.TeacherCreditRate = 2.25;
            customer.PolisCreditRate = 2.75;
            customer.CustomerCreditRate = 3.85;


            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("ID =" + id[i]);
                Console.WriteLine("Name =" + names[i]);
                Console.WriteLine("Phone Number =" + PhoneNumbers[i]);
                Console.WriteLine("City =" + cities[i]);
                Console.WriteLine("Type= " +types[i]);
                customer.Type(types[i]);
                Console.WriteLine("-----------------");
                
            }
           

        }

    }
}