using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExampleAddMehtod
{
    class MyDictionary<TKey, TValue>
    {
        
   

        TKey[] Id;
        TValue[] Name;
        TKey[] KeyTempArray;
        TValue[] NameTempArray;

        public MyDictionary() {

            Id = new TKey[0];
            Name = new TValue[0];
        }

        public void Add(TKey id, TValue name) {

            KeyTempArray = Id;
            NameTempArray = Name;

            Id = new TKey[Id.Length + 1];
            Name = new TValue[Name.Length + 1];

            for (int i = 0; i < Id.Length - 1; i++)
            {
                Id[i] = KeyTempArray[i];
                Name[i] = NameTempArray[i];
            }
            Id[Id.Length - 1] = id;
            Name[Name.Length - 1] = name;
        }

        public TKey[] ids
        {

            get { return Id; }
        }
        public TValue[] valuess
        {

            get { return Name; }

        }
        public int NameLength
        {

            get { return Name.Length; }
        }

      


    }
}
