using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> //I will work with T.
    {

        T[] items;
        public MyList() //constructor also when we new the MylistClass , Mylist will be working automaticly.
        {
            items = new T[0]; //we constructor the array and we defined the 0 element.

            

        }

        public void Add(T item) //t we can use any type in main class. it can be string or int etc.
        {
            
            T[] tempArray= items; // temArray is defined the items reference number to not dissaper when we create new array length.
            //when we add more  add information to array then we have to use again to new and before value we defined the tempArray because items previous value or string will be dissapear.
            items = new T[items.Length+1]; //we added the items numbers +1 to use value.it is dynamic.but we have problem abour reference number. reference number will be dissapear.
            // now tempArray have to add the previous items to new items.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //previous items are added by tempArray to new items

            }

            items[items.Length-1] = item; //length how many items have it is start from 1,but we using inside the array numbers it is start from 0 that's why we started -1 value.and we added last item value to last item array.


        }

    }
}
