namespace ValueReferanceType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 20;

            num1= num2;
            num2 = 70;

            //what is the num1 ? 

            //num1=20 is result
            Console.WriteLine(num1);

            int[] number1 = new int[] { 150, 200, 300, 400 };
            int[] number2 = new int[] { 500, 600, 700, 800, 900 };

            number1 = number2;

            number2[0] = 999;
            Console.WriteLine(number1[0]);

            //what is the number1[0] ??
            
            //number1[0]=12 is Result




        }
    }
}