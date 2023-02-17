namespace IntroCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String categoryTag = "Category";
            int studentsNumbers = 32000;
            double interestrate = 1.45;
            bool didsheloggedin = false;
            double usdyesterday = 7.55;
            double usdtoday = 7.55;
            if (usdyesterday>usdtoday)
            {
                Console.WriteLine("Down button shows in USD");
            }
            else if (usdyesterday<usdtoday)
            {
                Console.WriteLine(" Up button shows in USD");
            }
            else
            {
                Console.WriteLine("Not Changed");
            }

            if (didsheloggedin) {
                Console.WriteLine("Settings Button");

            }
            else
            {
                Console.WriteLine("lOG İN");
            }
            Console.WriteLine(categoryTag);



            
            



        }
    }
}