using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DataBaseLoggerService : ILoggerService //We have to this template
    {
        public void Log()
        {
            Console.WriteLine("Data Base was  Logged..! ");
        }
    }
}
