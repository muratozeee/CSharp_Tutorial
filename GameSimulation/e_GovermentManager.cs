using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
     class e_GovermentManager:IPersonManager
    {

        public string TcId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirhOfDate { get; set; }
        public string Status { get; set; }


        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            Console.WriteLine("You were registered from e-Goverment..! ");
        }

        public void Update()
        {
            Console.WriteLine("You were Updated from e-Goverment..! ");
        }
    }
}
