using System.Collections.Generic;

namespace Exampless
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            GenericManager<string> teachers= new GenericManager<string>();

            teachers.Add("Gökhan");
            teachers.Add("Atabak");
            Console.WriteLine(teachers.Length);
            foreach (var item in teachers.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(teachers.Length);

        }
    }
    

       
    }
