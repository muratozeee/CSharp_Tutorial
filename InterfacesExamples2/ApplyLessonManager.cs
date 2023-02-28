using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExamples2
{
    class ApplyLessonManager
    {

       

       public void LessonsInformation(List<ILessonManager> lessonManagers)
        {

            Console.WriteLine("You can select the Lessons");
            foreach (var lessons in lessonManagers)
            {
                lessons.Students();
            }
        }
        public void LessonInformation(ILessonManager lessonManager,List<ILoggerManager> loggerManagers)
        {

            lessonManager.Students();

            foreach (var items in loggerManagers)
            {
                items.Log();
            }
        }

    }
}
