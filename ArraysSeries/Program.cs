namespace ArraysSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] students = {"Murat","Suat","Faruk"};
            students[0] = "Murat";
            students[1] = "Suat";
            students[2] = "Faruk";

            foreach (String studentss in students)
            {
                Console.WriteLine("Students Name= "+studentss);


            }


        }
    }
}