namespace Methods22VideoHw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Console.WriteLine(Add2());

            //int number1 ;
            //int number2 = 30;
            //int result = Add3(out number1,number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);

            int number1 = 10;
            int number2 = 20;
            int number3 = 2;

            Console.WriteLine(Multiply(number1,number2,number3));
            Console.WriteLine(Multiply(number1,number2));


            Console.WriteLine(Sum(5,6,7,5,8));





            int nu1m = 0;
        }

        //static void Add()
        //{
        //    Console.WriteLine("Added!!!");
        //}
        //static int Add2(int number1 = 20, int number2 = 30)
        //{
        //    return number1 + number2;
        //}



        //static int Add3(out int number1,int number2)
        //{
        //    number1 = 5;
        //    return number1 + number2;   
        //}

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 *number3;
        }

        static int Sum(int number1,params int [] numbers)
        {
            return numbers.Sum();

        }
        
    }
}