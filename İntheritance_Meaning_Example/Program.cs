using InheritanceExample;

namespace İntheritance_Meaning_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat= new Cat();     //we defined the cat

            cat.animalName = "Zeus";    //cat reached the animalname with inheritance
            cat.animalGender = "Male"; //Normally .animalGender is in the AnimalManager
            cat.animalAge = 3;         //But we inherite the cat:AnimalManager
            cat.animalColor = "Black"; // I mean AnimalManager is base Class

            cat.AnimalInformation();





        }
    }
}