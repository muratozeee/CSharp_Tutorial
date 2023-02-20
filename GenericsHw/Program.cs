using System.Collections.Generic;

namespace GenericsHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> cities = new List<string>();
            cities.Add("Istanbul");
            cities.Add("Istanbul");
            cities.Add("Istanbul");
            cities.Add("Istanbul");
            Console.WriteLine(cities.Count);
            

            MyList<string> cities2 = new MyList<string>(); //whatever we want to put type of values we can add it.
            cities2.Add("Malatya");
            cities2.Add("Malatya");
            cities2.Add("Malatya");
            cities2.Add("Malatya");
            cities2.Add("Malatya");
            Console.WriteLine(cities2.Count);
           
        
        }

        
    }
    class MyList <T>

    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array=new T[0];
           
             
        }
        public void Add(T item)
        {
         tempArray=array;
            array = new T[array.Length + 1];

         
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length-1] = item;
            
        }
        public int Count
        {
            get { return array.Length; }
            
        }


    }

}