using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
     
        public int Id { get; set; } //this object can hold customer information. we are calling properties for DataBase

        public string _name;  
        public string Name { 
            get { return "Mr."+_name.ToUpper(); } //WE write Displat Mr.Faruk
            
            set {_name = value; } 
        }
        public string City { get; set; }    


    }
}
