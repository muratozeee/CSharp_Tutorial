using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class IndividualCustomer:Customer  //inharitance we are calling it.
    {
        
        public string CustomerTcNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }

    }
}
