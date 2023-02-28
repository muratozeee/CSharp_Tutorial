using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("transport Credit was Calculated paying plan");
        }

        public void DoitSomething()
        {
            throw new NotImplementedException();
        }
    }
}
