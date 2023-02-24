using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampless
{
     class GenericManager<T>
    {
        T[] teachername;
        T[] tempArray;
        public GenericManager(){
            teachername = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = teachername;

            teachername=new T[tempArray.Length+1];

            teachername[teachername.Length-1]=item;
            for (int i = 0; i <teachername.Length-1; i++)
            {
                teachername[i] = tempArray[i];
            }



        }
        public int Length
        {
            get { return teachername.Length;}
        }
        public T[] Items { 
       
            get { return teachername; }
        }

    }
}
