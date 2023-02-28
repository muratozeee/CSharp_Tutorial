using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExamples2
{
    class SmsLoggerTeacher : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Sms was Logged for Teachers..!");

        }
    }
}
