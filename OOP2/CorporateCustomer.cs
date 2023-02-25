using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
  class CorporateCustomer : Customer //Entity it has not operation just have value.
    {
       
        public string CustomerCompany { get; set; }
        //if we dont calculate numbers,we can defined the string them. it is better for transfer word or another software.
        public string TaxNo { get; set; }

    }
}
