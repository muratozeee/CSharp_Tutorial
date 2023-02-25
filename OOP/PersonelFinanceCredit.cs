using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PersonelFinanceCredit : ICreditManager  //Then We have to  implement the interface with bulb.
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit was calculated paying plan.");

        }

        public void Doitsomething()
        {
            throw new NotImplementedException();
        }
    }
}
