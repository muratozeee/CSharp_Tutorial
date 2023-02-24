using System.Globalization;

namespace DictionaryExampleAddMehtod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            

            myDictionary.Add(14523, "Gökhan Çınar");
            myDictionary.Add(23423, "Rıfat Edizkan");
            myDictionary.Add(35323, "Salih Fadıl");
            myDictionary.Add(42123, "Bilginer Gülmez");
            myDictionary.Add(54232, "Kemal Keskin");
            myDictionary.Add(65475, "Burak Urazel");




            for (int i = 0; i < myDictionary.NameLength; i++)
            {
                Console.WriteLine("Teacher ID={0}  Teacher={1}", myDictionary.ids[i], myDictionary.valuess[i] );

            }

            Console.WriteLine("Total Teachers= "+myDictionary.NameLength);

        }
    }
}