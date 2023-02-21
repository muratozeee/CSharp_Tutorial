namespace InheritanceExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1= new Person();
            Person person2= new Person();
            Person person3=new Person();
            Person person4= new Person();
            Person person5= new Person();
            
            CustomerManager customerManager= new CustomerManager();
            PoliceCredit policeCredit = new PoliceCredit();
            TeacherCredit teacherCredit = new TeacherCredit();
            StudentCredit studentCredit = new StudentCredit();
            policeCredit.PoliceCreditRate = 1.65;
            teacherCredit.TeacherCreditRate = 1.55;
            studentCredit.StudentCreditRate = 1.50;
            
            person1.Id = 1;
            person1.Name = "Murat";
            person1.Surname = "Oz";
            person1.PhoneNumber = 0531404415;
            person1.City = "Istanbul";
            person1.Type = "Student";

            person2.Id = 2;
            person2.Name = "Suat";
            person2.Surname = "Stlms";
            person2.PhoneNumber =051214015;
            person2.City = "Istanbul";
            person2.Type = "Police";


            person3.Id = 3;
            person3.Name = "Faruk";
            person3.Surname = "Coskun";
            person3.PhoneNumber = 0542304415;
            person3.City = "Istanbul";
            person3.Type = "Student";

            person4.Id = 4;
            person4.Name = "Bayram";
            person4.Surname = "Aslan";
            person4.PhoneNumber = 0553404415;
            person4.City = "Istanbul";
            person4.Type = "Teacher";

            person5.Id = 5;
            person5.Name = "Samet";
            person5.Surname = "kalan";
            person5.PhoneNumber = 053123415;
            person5.City = "Eskişehir";
            person5.Type = "Police";

            

            customerManager.Add(person1, teacherCredit, studentCredit, policeCredit);
            customerManager.Add(person2, teacherCredit, studentCredit, policeCredit);
            customerManager.Add(person3, teacherCredit, studentCredit, policeCredit);
            customerManager.Add(person4, teacherCredit, studentCredit, policeCredit);
            customerManager.Add(person5, teacherCredit, studentCredit, policeCredit);





















        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Type { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
    }
    class PoliceCredit:Person
    {
        public double PoliceCreditRate { get; set; }



    }
    class TeacherCredit : Person
    {
        public double TeacherCreditRate { get; set;}
    }
    class StudentCredit : Person
    {
        public double StudentCreditRate { get; set;}
    }
    class CustomerManager
    {
        public void Add(Person person,TeacherCredit teacher,StudentCredit student,PoliceCredit police)
        {
            Console.WriteLine("Personal ID: "+person.Id);
            Console.WriteLine("Personal Name: "+person.Name);
            Console.WriteLine("Personal Surname: "+person.Surname);
            Console.WriteLine("Personal City: "+person.City);
            Console.WriteLine("Personal Type: "+person.Type);
            if (person.Type=="Student")
            {
                Console.WriteLine("Student Credit Rate= "+student.StudentCreditRate);
            }
            else if (person.Type == "Teacher")
            {
                Console.WriteLine("Teacher Credit Rate= "+teacher.TeacherCreditRate);
            }
            else if (person.Type=="Police")
            {
                Console.WriteLine("Police Creadit Rate= "+police.PoliceCreditRate);
            }
            else
            {
                Console.WriteLine("İnvalid Type...!");
            }




            Console.WriteLine("----------------------------");
        }
    }
    
}