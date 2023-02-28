using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
    class PersonelCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personel Credit was Calculated paying plan");
        }

        public void DoitSomething()
        {
            throw new NotImplementedException();
        }
    }
}
