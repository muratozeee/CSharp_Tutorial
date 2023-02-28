namespace InterfacesExampless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCredit=new PersonelCreditManager();
            ICreditManager transportCredit=new TransportCreditManager();
            ICreditManager housingCredit=new HousingCreditManager();
            ICreditManager smallBusiness=new SmallBusinessCreditManager();

            ILoggerManager smsLoggerManager=new SmsLoggerManager();
            ILoggerManager dataLoggerManager=new DataBaseLoggerManager();
            ILoggerManager fileLoggerManager = new FileLoggerManager();

            List<ICreditManager> credits = new List<ICreditManager> { personalCredit, transportCredit, housingCredit ,smallBusiness};

            ApplyManager apply = new ApplyManager();

            apply.FirstInformation(credits);

            Console.WriteLine("-------------");

            List<ILoggerManager> loggers= new List<ILoggerManager>() {smsLoggerManager,dataLoggerManager,fileLoggerManager };

            Console.WriteLine("You selected Credit..!");
            apply.Apply(transportCredit, loggers);



           

        }
    }
}