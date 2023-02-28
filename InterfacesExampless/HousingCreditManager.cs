using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit was Calculated paying plan");
        }

        public void DoitSomething()
        {
            throw new NotImplementedException();
        }
    }
}
