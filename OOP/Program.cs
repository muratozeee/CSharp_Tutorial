using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelCredit= new PersonelFinanceCredit(); //we are calling them in main class to use operation.
            ICreditManager transportCredit = new TransportCreditManager();
            ICreditManager housingCredit =new HousingCreditManager();
            ICreditManager smalbusiness=new SmallBusinessManager();

       
        

            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService dataBaseLoggerService=new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();
            ApplicationManager applicationManager = new ApplicationManager();

            // List<ILoggerService> loggerServices = new List<ILoggerService>() {new DataBaseLoggerService(),new SmsLoggerService()};

            //  applicationManager.DoApply(transportCreditManager,loggerServices); //WE use the both methods to see the in display.

            //  applicationManager.DoApply(new SmallBusinessManager(), new List < ILoggerService > 
            //      { new DataBaseLoggerService(), new SmsLoggerService() }); //we used the list method to both database logger and sms logger.

            //List<ILoggerService> loggerss= new List<ILoggerService>() { new DataBaseLoggerService(),new SmsLoggerService(),new FileBaseLoggerService() };

            //applicationManager.DoApply(smalbusinessManager, loggerss);
            // Console.WriteLine("-------------------");

            // applicationManager.DoApply(smalbusinessManager,loggerss);




             List<ICreditManager> credits= new List<ICreditManager>() {personelCredit,transportCredit,housingCredit };

              applicationManager.DoCreditFirstInformation(credits);

            Console.WriteLine("---------------------");
           List<ILoggerService> logs=new List<ILoggerService>() {smsLoggerService,dataBaseLoggerService,fileLoggerService };

            applicationManager.DoApply(transportCredit,logs);



           




        }
    }
}