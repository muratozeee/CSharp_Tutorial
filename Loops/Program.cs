using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string course1 = "Software Developer Camp";
            string course2 = "Entry level programing for basis";
            string course3 = "Java";
            string[] courses = new string[] { "Software Developer Camp" , "Entry level programing for basis", "Java" };

            for (int i = 0; i <courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("Page break-footer");
            for (int i = 0; i <10 ;i=i+2)
            {
                Console.WriteLine(i);
            }
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
