namespace OOP3
{
    class FileBaseLoggerService : ILoggerService //We have to this template
    {
        public void Log()
        {
            Console.WriteLine("File was  Logged..! ");
        }
    }
}
