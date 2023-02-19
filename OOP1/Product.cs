using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{

    
    internal class Product //Entity 
    {
        //in this class which has just options.

        //but also we can use CRUD operations.It means Creat, Read, Update,Delete Operations.

        public int Id { get; set; }  // prop +tap+tap then it will be come.it means Snippet.
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }



    }
}
