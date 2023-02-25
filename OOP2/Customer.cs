using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    //Business Classes.

  class Customer //Classes have 2 types.First type has a properties.Second Type is operations
    {

        public int Id { get; set; }   //Id and CustomerNo is same Corparate and individual customer. and also they inharite the Customer 
        //that's why they are using this variables.
        public string CustomerNo { get; set; }
        //when we hold properties. we dont do operation
        //or when we hold operations. we dont hold properties.



        //if we dont calculate numbers,we can defined the string them. it is better for transfer word or another software.

    }
}
