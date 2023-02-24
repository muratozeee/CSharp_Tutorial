using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hw_Example
{
    class MyDictionary<Tkey,TValue> //MyDictionary is defined the Tkey and TValue as double and string
    {
        Tkey[] key;
        Tkey[] keyTempArray;    //these ones are defined as  Arrays
        TValue[] names;
        TValue[] namesTempArray;
        public MyDictionary()
        {
            key = new Tkey[0];
            names= new TValue[0]; //key and names have 0 memory arrray.and key and names have been defined  new reference
        }
        public void Add(Tkey ky,TValue nm) //we can see the Code Logic in this code about backround.
        {//this method using for doing something we used the void.and we have key and name we will take the in the main section.
            keyTempArray = key;
            namesTempArray = names;   // we create the new reference numbers to key and name which are informations are hold by keyTempArray and nameTempArray
            //why we ara using this one.Because when we create the new reference array numbers ,before reference array numbers will be deleted.
            //That's why we are hold them with tempArrays
            key = new Tkey[key.Length + 1];   //we defined the new reference number to next array for key(ID)
            names=new TValue[names.Length + 1]; //we defined the new reference number to next array for value(name)

            for (int i = 0; i < key.Length-1; i++)
            {
                key[i] = keyTempArray[i];   //key arrays are defined by keyTemparrays previous informations.          
            }
            for (int i = 0; i < names.Length-1; i++)
            {
                names[i] = namesTempArray[i];  //name arrays are defined by namesTemparrays previous informations.          
            }
            key[key.Length - 1] = ky;
            names[names.Length-1]= nm;


        }

        public Tkey[] keyss
        {
            get { return key; }  //we want to show keys(ID) in display that's why we are getting the information.
        }
        public TValue[] namess
        {
            get { return names; } //we want to show Value(Names) in display that's why we are getting the information.
        }
        public int keyLength    //we want to show Key length of memory in display that's why we are getting the information.
        {

            get { return key.Length; }
        }
        public int nameLength
        {
            get { return names.Length; }   //we want to show name length of memory in display that's why we are getting the information.
        }


     


    }
}
