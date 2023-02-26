using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class SmallBusinessManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Small Business Credit was Calculated paying plan..!");
        }

        public void Doitsomething()
        {
            throw new NotImplementedException();
        }
    }
}
