namespace InterfacesExamples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILessonManager electricMacinary = new ElectricMachinaryManager();
            ILessonManager powerSystem = new PowerSystemManager();
            ILessonManager distribution = new DistributionSysmtemManager();
            ILessonManager transmission = new TransMissionSysmManager();

            ILoggerManager smsLoggerStudents = new SmsLoggerStudent();
            ILoggerManager smsLogggerTeacher = new SmsLoggerTeacher();

            List<ILessonManager> lessonManagers = new List<ILessonManager>() { electricMacinary, powerSystem, distribution, transmission };
            List<ILoggerManager> loggerManagers = new List<ILoggerManager>() { smsLoggerStudents, smsLogggerTeacher };

            ApplyLessonManager applyLessonManager = new ApplyLessonManager();

            applyLessonManager.LessonsInformation(lessonManagers);
            Console.WriteLine("----------------");

            applyLessonManager.LessonInformation(electricMacinary, loggerManagers);
            
            


            }
    }
}