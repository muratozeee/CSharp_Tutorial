using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
    class SmsLoggerManager : ILoggerManager

    {
        public void Log()
        {
            Console.WriteLine("Sms was Logged..!");
        }
    }
}
