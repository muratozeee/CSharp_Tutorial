using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
    class ApplyVerifications 
    {

        public void gamerInformation(List<IPersonManager> personManager)
        {
            foreach (var info in personManager)
            {
                Console.WriteLine("e-Goverment ID: " + info.TcId);
                Console.WriteLine("Gamer Name: " + info.Name);
                Console.WriteLine("Gamer Surname:  " + info.Surname);
                Console.WriteLine("Gamer Birth Of Date: "+info.BirhOfDate);
                Console.WriteLine("Status: "+info.Status);
                Console.WriteLine("--------");

            }


        }

        
    }
}
