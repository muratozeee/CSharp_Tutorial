using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Murat", "Enging", "Halil", "Kerem" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            ////names[4] = "Ilker"; //we can not use it because we can not use 4 dont have memory.
            //names = new string[5];  //but we can creat new names then we can use it
            //names[4] = "ilker";
            //Console.WriteLine(names[4]); //we write the ilker then
            //Console.WriteLine(names[2]); //but we cannot see the "Halil" because we created the new names then "Muret","Enging","halil" and "Kerem" are deleted
            //                             //these informations is coming from data base normally.That's why when we want to change or add something, it is problem.In this case, We are using Collections.

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //when we used List.we Updated List which we can add easily and we can see the at screen

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("Ilker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[1]);




        }
        }
}