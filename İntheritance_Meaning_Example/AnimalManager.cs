using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class AnimalManager
    {
        public string animalName;
        public string animalGender;
        public string animalColor;                //we can control method and properties manager or service.
        public int animalAge;
        public void AnimalInformation()
        {
            Console.WriteLine("Animal Name ="+animalName);
            Console.WriteLine("Animal Gender ="+animalGender);
            Console.WriteLine("Animal Color ="+animalColor);
            Console.WriteLine("Animal Age ="+animalAge);

        }
    }
}
