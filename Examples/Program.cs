using System.Collections.Generic;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("a");

            Console.WriteLine(names.Length);

           

        }
     

        internal class MyList<T> 
        {

            T[] items; 
            public MyList()
            {
                items = new T[0];
            }

            public void Add(T item)

            {
                T[] tempArray = items;

                items = new T[items.Length + 1]; 


                for (int i = 0; i < items.Length - 1; i++)  
                {
                    items[i] = tempArray[i];

                }

                items[items.Length - 1] = item;

            }

            public int Length {    
                get { return items.Length; }
            }

            public T[] Items          
            {
                get { return items; }
            }
        }
    }
   

}