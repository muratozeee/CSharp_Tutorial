using System.Collections.Generic;

namespace Dictionary_Hw_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<double,string> dictionaryManager= new MyDictionary<double, string>();
            //MyDictionary is defined the as a dictionary method. it has  key and value ,
            //key=double value=string
            //Add method check the MyDictionary class because we write manual codes about Add
            dictionaryManager.Add(151220162128, "Murat"); //we use the add operiton to systems.
            dictionaryManager.Add(151220161512, "Faruk");
            

            foreach (var id in dictionaryManager.keyss)  //we used the foreach to show display.
            {//we show id as a keys in display.
                Console.WriteLine("Student ID :{0} ",id);
            }
            foreach (var name in dictionaryManager.namess)
            {//we show names as a value in display.
                Console.WriteLine("Student Name :{0}",name);
            }
            //we show the display about key and name length of memory.
            Console.WriteLine("Student ID Lenght of memory: {0}",dictionaryManager.keyLength); 
            Console.WriteLine("Student Names Length of memory: {0}",dictionaryManager.nameLength);


        }
    }
}