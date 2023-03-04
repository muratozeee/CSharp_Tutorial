namespace GameSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IPersonManager gamer1=new PersonManager() {TcId="46445542211",Name="Murat",Surname="Oz",BirhOfDate="23.12.1995",Status="Student"};
            IPersonManager gamer2 = new PersonManager() {TcId="652145521",Name="Suat",Surname="Satılmıs",BirhOfDate="12.05.1998",Status="Police" };
            IPersonManager gamer3=new PersonManager() { TcId = "8752145521", Name = "Faruk", Surname = "Coskun", BirhOfDate = "12.08.1988" ,Status="Teacher"};

            IPersonManager gamer4 = new  e_GovermentManager() { TcId = "46445542211", Name = "Bayram", Surname = "Aslan", BirhOfDate = "01.05.1995",Status="Farmer"}; ;

            List<IPersonManager> gamerList=new List<IPersonManager>() {gamer1,gamer2,gamer3,gamer4 };

            

            ApplyVerifications applyVerifications=new ApplyVerifications();
            

            applyVerifications.gamerInformation(gamerList);

            gamer1.Login();
            gamer1.Update();
            gamer1.Delete();

            gamer4.Login();


           
            Dictionary<string,IPersonManager> keyValuePairs= new Dictionary<string,IPersonManager>();


            keyValuePairs.Add("Student", gamer1);
            keyValuePairs.Add("Police", gamer2);
            keyValuePairs.Add("Teacher", gamer3);
            keyValuePairs.Add("Farmer", gamer4);

       


                if (keyValuePairs.TryGetValue("Student",out gamer1))
                {
                    Console.WriteLine("We have Discount %65  for Students Student Gamers:  "+gamer1.Name);
                }
                 if (keyValuePairs.TryGetValue("Police",out gamer2))
                {
                    Console.WriteLine("We have Discount %45  for  Police Gamers:  " + gamer2.Name);
                }
                if (keyValuePairs.ContainsKey("Teacher"))
                {
                    Console.WriteLine("We have Discount %30  for  Teachers Gamers:  " + gamer3.Name);
                }
                else
                {
                    Console.WriteLine("We dont have discount for you"+gamer4.Name);
                }
            

           















        }
       



    }
}