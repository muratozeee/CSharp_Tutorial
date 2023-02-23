using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Dictionary
{
    internal class Program
    { 

        //Key-Value
        //Auto-Car
        static void Main(string[] args)
        {

            //dictionary
            var dictionary = new Dictionary<string, string>(); //this one is safe
            dictionary["name"] = "Murat";
            Console.WriteLine(dictionary["name"]);


            //Hashtable
            var hashtable=new Hashtable();//if you want we can syncronous

            hashtable["name"] = "Murat";
            hashtable["age"] = 28;

            var age = hashtable["age"]; //var==object it is using object.
            object name = hashtable["name"];
            Console.WriteLine(age);
            Console.WriteLine(name);
         

            var concurrentDictionary=new ConcurrentDictionary<string, string>();

            concurrentDictionary["name"] = "Muratt";
            Console.WriteLine(concurrentDictionary["name"]);//also this one is safe
            //advantage of this name concurrentDictionary.TryAdd,Remove,Update etc we can use them.
            var newName =concurrentDictionary["name"];       



            //immutable Dictionary

            var immutableDictionary = ImmutableDictionary<string, string>.Empty;//also build or something we can use it.,

            var newDictionary=immutableDictionary.Add("name", "Murat");

            Console.WriteLine(newDictionary["name"]);


            //Dictionary= 34.39 us in 100 items add //fastest
            //Hashtable= 36.84 us in 100 items  add 
            //concurrent= 49.61 us in 100 items add
            //İmmutable= 95.17 us in 100 items  add





        }
    }
}