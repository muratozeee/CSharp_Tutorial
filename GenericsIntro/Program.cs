namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); //we select the which type will be to T also we defined the new reference.

            names.Add("a");

            Console.WriteLine(names);


        }
    }
}