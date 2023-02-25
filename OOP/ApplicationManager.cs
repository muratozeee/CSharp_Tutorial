using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {

        //Method İnjection
        public void DoApply(ICreditManager creditManager,List<ILoggerService> loggerServices) 
        {
            creditManager.Calculate(); //it is coming from Personal Finance Credit,Transport,Housing all of them they can come and using.
                                       //it is very useful methods.

            // we use the more than 1 that's why we used the foreach

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditFirstInformation(List<ICreditManager> credits) //we want to all credits type will use for something.
        {


            foreach (var credit in credits)
            {
               credit.Calculate();

            }
        }

     
    }
}
