using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
    class DataBaseLoggerManager : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Data Base was Logged..!");

        }
    }
}
