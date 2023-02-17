namespace CapsulationMethodExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealEstate realEstate = new RealEstate();

            realEstate.Area = 85;
            realEstate.FloorNum = 2;
            realEstate.RoomNum = "2+1";
            realEstate.District = "Bahçelievler/Zafer district";
            realEstate.Color = "brown";

            Console.WriteLine("Apartment's Area = "+realEstate.Area);
            Console.WriteLine("Apartment's Floor Number = "+realEstate.FloorNum);
            Console.WriteLine("Apartment's Room Numbers= "+realEstate.RoomNum);
            Console.WriteLine("Apartment's District= " + realEstate.District);
            Console.WriteLine("Apartment's Color = " + realEstate.Color);
            Console.WriteLine("-----------------------");

           
        }
    }
}