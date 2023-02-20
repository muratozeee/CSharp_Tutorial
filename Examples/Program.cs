using System.Collections.Generic;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> pavilions = new List<string>() {"Usa","China"};


            pavilions.Add("Türkiye");
            pavilions.Add("Azerbaycan");
            System.Console.WriteLine(pavilions.Count);
            foreach (var items in pavilions)
            {
                System.Console.WriteLine(items);
            }





        }
    }
}