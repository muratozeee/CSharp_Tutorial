using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExampless
{
     class ApplyManager
    {
        public void FirstInformation(List<ICreditManager> creditManagers)
        {


            foreach (var credits in creditManagers)
            {
                credits.Calculate();

            }

        }
        public void Apply(ICreditManager creditManager,List<ILoggerManager> loggerManagers)
        {

            creditManager.Calculate();

            foreach (var logs in loggerManagers)
            {
                logs.Log();
            }
        }
    }
}
