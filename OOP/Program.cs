using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCredit= new PersonelFinanceCredit(); //we are calling them in main class to use operation.
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingCreditManager =new HousingCreditManager();
            ICreditManager smalbusinessManager=new SmallBusinessManager();

            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService dataBaseLoggerService=new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();
            ApplicationManager applicationManager = new ApplicationManager();

            //List<ILoggerService> loggerServices = new List<ILoggerService>() {new DataBaseLoggerService(),new SmsLoggerService()};

//            applicationManager.DoApply(transportCreditManager,dataBaseLoggerService); //WE use the both methods to see the in display.

    //  applicationManager.DoApply(new SmallBusinessManager(), new List < ILoggerService > 
//      { new DataBaseLoggerService(), new SmsLoggerService() }); //we used the list method to both database logger and sms logger.

List<ILoggerService> loggerss= new List<ILoggerService>() { new DataBaseLoggerService(),new SmsLoggerService() };

            applicationManager.DoApply(smalbusinessManager, loggerss);




           // List<ICreditManager> credits= new List<ICreditManager>() {personelFinanceCredit,transportCreditManager,housingCreditManager };

            //applicationManager.DoCreditFirstInformation(credits);





           




        }
    }
}