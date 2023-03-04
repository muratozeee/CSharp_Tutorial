using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
     class PersonManager:IPersonManager
    {
        public string TcId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirhOfDate { get; set; }
        public string Status { get; set; }


        public void Delete()
        {
            Console.WriteLine("your member was Deleted..!");
        }

        public void Login()
        {
            Console.WriteLine("Registered was Successfully.");

            
        }

        public void Update()
        {
            Console.WriteLine("your member was Updated..!");
        }
    }
}
