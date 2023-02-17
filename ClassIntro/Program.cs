using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Murat";
            int age = 27;

            Course course1 = new Course();
            Course course2 = new Course();
            Course course3 = new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Murat";
            course1.WathcingRate = 10;

            course2.CourseName = "Java";
            course2.Teacher = "Suat";
            course2.WathcingRate = 15;

            course3.CourseName = "Python";
            course3.Teacher = "Faruk";
            course3.WathcingRate = 30;

            Console.WriteLine(course1.CourseName + " : " + course1.Teacher);

            Course[] course = new Course[] {course1,course2,course3};

            foreach (Course courses in course)
            {
                Console.WriteLine(courses.CourseName + " = " +courses.Teacher);
            }
            var names = "Muratt";
            float numberss =5254456 ;

            Console.WriteLine(name);
            Console.WriteLine(numberss+"  " +names);

            int x = 10;
            int y = 10;
            int z = 30;
            var result= x> y ? "x is greater than y" : "y is greater than x";
            Console.WriteLine(result);

            if (x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is greater than x");
            }

             var resultt = x > y ? "X greater than Y" :
                y > z ? "Y greater than Z" : "Z greater than Y";
            Console.WriteLine(resultt);

            int monthNum = 8;

            switch (monthNum)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid number Day");
                    break;
            }

            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index<=5);

            HospitalPers hospital1= new HospitalPers();
            HospitalPers hospital2 = new HospitalPers();
            HospitalPers hospital3 = new HospitalPers();
            HospitalPers hospital4 = new HospitalPers();
            HospitalPers hospital5 = new HospitalPers();
            HospitalPers hospital6 = new HospitalPers();
            HospitalPers hospital7 = new HospitalPers();
            HospitalPers hospital8 = new HospitalPers();
            HospitalPers hospital9 = new HospitalPers();
            HospitalPers hospital10 = new HospitalPers();


            HospitalPers[] hospitalPers =new HospitalPers[] { hospital1, hospital2, hospital3,
                hospital4, hospital5, hospital6,
                hospital7, hospital8, hospital9, hospital10 };
            hospital1.ResignNum = 15;
            hospital1.LeaveJobNum = 20;
            hospital1.NewPersonalNum = 60;
            hospital1.TotalPersonalNum = 650;

            hospital2.ResignNum = 12;
            hospital2.LeaveJobNum = 55;
            hospital2.NewPersonalNum = 65;
            hospital2.TotalPersonalNum = 720;

            hospital3.ResignNum = 16;
            hospital3.LeaveJobNum = 25;
            hospital3.NewPersonalNum = 85;
            hospital3.TotalPersonalNum = 850;

            hospital4.ResignNum = 14;
            hospital4.LeaveJobNum = 22;
            hospital4.NewPersonalNum = 34;
            hospital4.TotalPersonalNum = 450;

            hospital5.ResignNum = 43;
            hospital5.LeaveJobNum = 67;
            hospital5.NewPersonalNum = 120;
            hospital5.TotalPersonalNum = 950;

            hospital6.ResignNum = 5;
            hospital6.LeaveJobNum = 2;
            hospital6.NewPersonalNum = 5;
            hospital6.TotalPersonalNum = 1050;

            hospital7.ResignNum = 22;
            hospital7.LeaveJobNum = 44;
            hospital7.NewPersonalNum = 42;
            hospital7.TotalPersonalNum = 842;

            hospital8.ResignNum = 125;
            hospital8.LeaveJobNum = 55;
            hospital8.NewPersonalNum = 10;
            hospital8.TotalPersonalNum = 450;

            hospital9.ResignNum = 23;
            hospital9.LeaveJobNum = 65;
            hospital9.NewPersonalNum = 62;
            hospital9.TotalPersonalNum = 535;


            hospital10.ResignNum = 15;
            hospital10.LeaveJobNum = 20;
            hospital10.NewPersonalNum = 60;
            hospital10.TotalPersonalNum = 150;

            int counttt = 1;

            foreach (HospitalPers hospitall in hospitalPers )
                      {
            Console.WriteLine(counttt+") Total Personal Number = "+hospitall.TotalPersonalNum);
            Console.WriteLine(counttt+") New Personal Number= " + hospitall.NewPersonalNum);
            Console.WriteLine(counttt +") Resing Personal Number= " + hospitall.ResignNum);
            Console.WriteLine(counttt + ") Leave Personal Number" + hospitall.LeaveJobNum);
            Console.WriteLine("-------------------------------------------------------");
                counttt++;
                
                       }
            int count = 1;
            int totalPers = 0;
            int totalResig = 0;
            int totalLeave = 0;
            int totalNewPersonal = 0;
            
            for (int i = 0; i <hospitalPers.Length; i++)
            {
               
                Console.WriteLine(count+".)Hastane New Personal Number =  " + hospitalPers[i].NewPersonalNum);
                Console.WriteLine(count+ ".)Hastane Resign Personal Number =" + hospitalPers[i].ResignNum);
                Console.WriteLine(count+".)Hastane Leave Personal Number= " + hospitalPers[i].LeaveJobNum);
                Console.WriteLine(count + ".)Hastane Total Personal Number= " + hospitalPers[i].TotalPersonalNum);
                Console.WriteLine("-------------------------------------------------------");
                count++;
                totalPers = totalPers + hospitalPers[i].TotalPersonalNum;
                totalLeave = totalLeave + hospitalPers[i].LeaveJobNum;
                totalNewPersonal = totalNewPersonal + hospitalPers[i].NewPersonalNum;
                totalResig = totalResig + hospitalPers[i].ResignNum;



            }
            int a = 0;
            int count1=1;
            do
            {
                Console.WriteLine(count1 + ".)Hastane New Personal Number =  " + hospitalPers[a].NewPersonalNum);
                Console.WriteLine(count1 + ".)Hastane Resign Personal Number =" + hospitalPers[a].ResignNum);
                Console.WriteLine(count1 + ".)Hastane Leave Personal Number= " + hospitalPers[a].LeaveJobNum);
                Console.WriteLine(count1 + ".)Hastane Total Personal Number= " + hospitalPers[a].TotalPersonalNum);
                Console.WriteLine("-------------------------------------------------------");
                count1++;
                totalPers = totalPers + hospitalPers[a].TotalPersonalNum;
                totalLeave = totalLeave + hospitalPers[a].LeaveJobNum;
                totalNewPersonal = totalNewPersonal + hospitalPers[a].NewPersonalNum;
                totalResig = totalResig + hospitalPers[a].ResignNum;
                a++;



            } while (a<10);
            Console.WriteLine("Total Hospital's New Personal Number = " + totalLeave);
            Console.WriteLine("Total Hospital's Resign Personal Number = " + totalNewPersonal);
            Console.WriteLine("Total Hospital's Leave Personal Number = " + totalResig);
            Console.WriteLine("Total Hospital's Personal Number = " + totalPers);
            Console.WriteLine("-------------------------------------------------------");


            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            Product product4 = new Product();
            Product product5 = new Product();
            Product product6 = new Product();


            Product[] product = new Product[] {product1,product2,product3,product4,product5,product6 };

            product1.productName = "Computer";
            product1.productBrand = "Toshiba";
            product1.productPrice = 20000;
            product1.productBarkode = 525452;



            product2.productName = "Mouse";
            product2.productBrand = "Logitech";
            product2.productPrice = 450;
            product2.productBarkode = 452524;


            product3.productName = "Keyboard";
            product3.productBrand = "Philips";
            product3.productPrice = 1500;
            product3.productBarkode = 852245;



            product4.productName = "Phone";
            product4.productBrand = "Apple";
            product4.productPrice = 28500;
            product4.productBarkode = 122415;



            product5.productName = "Headphone";
            product5.productBrand = "Apple";
            product5.productPrice = 4500;
            product5.productBarkode = 258485;


            product6.productName = "Shave Machine";
            product6.productBrand = "Braum";
            product6.productPrice = 1650;
            product6.productBarkode = 958525;
            int countProduct = 1;
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(countProduct+".)Product Name = " + product[i].productName);
                Console.WriteLine(countProduct+".)Product Brand = "+ product[i].productBrand);
                Console.WriteLine(countProduct+".)Product Price ="+ product[i].productPrice);
                Console.WriteLine(countProduct + ".)Product Barcode= " + product[i].productBarkode);
                Console.WriteLine("-------------------------------------------------------");
                countProduct++;
            }
            int countforeach = 1;
            foreach (Product production in product)
            {
                Console.WriteLine(countforeach + ".)Product Name = " + production.productName);
                Console.WriteLine(countforeach + ".)Product Brand = " + production.productBrand);
                Console.WriteLine(countforeach + ".)Product Price =" + production.productPrice);
                Console.WriteLine(countforeach + ".)Product Barcode= " + production.productBarkode);
                Console.WriteLine("-------------------------------------------------------");
                countforeach++;
            }

            int countwhile = 1;
            int b = 0;
            do
            {
                Console.WriteLine(countwhile + ".)Product Name = " + product[b].productName);
                Console.WriteLine(countwhile + ".)Product Brand = " + product[b].productBrand);
                Console.WriteLine(countwhile + ".)Product Price =" + product[b].productPrice);
                Console.WriteLine(countwhile + ".)Product Barcode= " + product[b].productBarkode);
                Console.WriteLine("-------------------------------------------------------");
                countwhile++;
                b++;
            } while (b<product.Length);






        }
    }
    class Course
    {

        public string CourseName { get; set; } //write the prob
        public string Teacher { get; set; }
        public int WathcingRate { get; set; }


    }
    class HospitalPers
    {
        public int NewPersonalNum  { get; set; }
        public int LeaveJobNum { get; set; }
        public int ResignNum { get; set; }
        public int TotalPersonalNum { get; set; }
    }

    class Product
    {
        public String productName { get; set; }
        public double productPrice { get; set; }
        public String productBrand { get; set; }
        public int productBarkode { get; set; }

    }
}
