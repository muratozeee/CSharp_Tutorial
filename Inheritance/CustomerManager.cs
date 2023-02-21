using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class CustomerManager
    {
       public double StudentCreditRate { get; set; }
        public double CustomerCreditRate { get; set; }
        public double PolisCreditRate { get; set; }
        public double TeacherCreditRate { get; set; }

        public void Type(string type) {

            if (type== "Student")
            {
                Console.WriteLine("Student Credit Rate ="+StudentCreditRate);
            }
            else if (type=="Police")
            {
                Console.WriteLine("Police Credit Rate ="+PolisCreditRate);
            }
            else if (type=="Teacher")
            {
                Console.WriteLine("Teacher Creadit Rate ="+TeacherCreditRate);
            }
            else if (type=="Customer")
            {
                Console.WriteLine("Customer Credit Rate ="+CustomerCreditRate);
            }
            else
            {
                Console.WriteLine("İnvalid Customer Type..!");
            }
        
        }
   
       
    }
  
    
}
