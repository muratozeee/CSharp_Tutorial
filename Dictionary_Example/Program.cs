using System.Xml.Linq;

namespace Dictionary_Example
{
    internal class Program
    {

        //key-value
        //Auto-Car
        static void Main(string[] args) //we use collection generic
        {

            //İt is our data base İnformation.
            EmployeeManager[] employees = new EmployeeManager[] { 
            new EmployeeManager("Ceo","Suat",25,200),
            new EmployeeManager("Manager","Murat",28,100),
            new EmployeeManager("Team Leader","Faruk",32,75),
            new EmployeeManager("Supervisor","Bayram",29,52),
             new EmployeeManager("HR","Gizem",28,45),
              new EmployeeManager("Intern","Rıfkı",28,4),

            };

            //we create the Employee Dictionary

            Dictionary<string,EmployeeManager> employeeManager= new Dictionary<string,EmployeeManager>();

            //now we are adding emloyees role in dictionary
           
            foreach (var role in employees)
            {
                 employeeManager.Add(role.Role,role); //key is string(role.Role),value is all employee itself(role)

               //key is defined by role.
                // when ı used the key ı will use this information in this code.

            }

            // Now how can we updated the about information with key;
            //Update.
            string KeytoUpdate = "Intern";
            if (employeeManager.ContainsKey(KeytoUpdate))
            {
                employeeManager[KeytoUpdate] = new EmployeeManager("Intern","Mustafa",21,25);
                Console.WriteLine("Empoloyee is updated with Role/Key:{0}",KeytoUpdate);
            }

            //Remove
            string KeytoRemove = "Ceo";
            if (employeeManager.Remove(KeytoRemove))
            {
                Console.WriteLine("Employee is Removed with Role/Key:{0}",KeytoRemove);
            }









            //also if we wrong the ceo write then our program will crash thats why we can check with if
            //fetch data is "Ceo" for example
            string key = "Ceo";
            if(employeeManager.ContainsKey(key))
            {
                EmployeeManager emp1 = employeeManager["Ceo"]; //key is "Ceo" from dictionary to take all information about employees in a object
                                                               //lets see the display about information

                Console.WriteLine("Employee Name: {0}, Role: {1} ,Salary: {2},Rate: {3}", emp1.Name, emp1.Role, emp1.Salary, emp1.Rate);

            }
            else
            {
                Console.WriteLine("No employee found with this key {0}",key);
            }
            //also we can use for value it is using true or false then we can do it let's seee.

            EmployeeManager result= null;
            //using TryGetValue() it returns true if the operation was succesful and false otherwise
            if (employeeManager.TryGetValue("Intern",out result)) //we can use the key to reach information about employee
            {
                Console.WriteLine("Value Retrieved");
                Console.WriteLine("Employee Name: "+result.Name);
                Console.WriteLine("Employee Role: "+result.Role);
                Console.WriteLine("Employee Age: "+result.Age);
                Console.WriteLine("Employe Salary: "+result.Salary);

            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

           

            for (int i = 0; i < employeeManager.Count; i++)
            {
                KeyValuePair<string, EmployeeManager> keyValuePair = employeeManager.ElementAt(i);

                Console.WriteLine("Value Retrieved");

                Console.WriteLine("Key :{0} Position is {1} ",keyValuePair.Key,i);

                Console.WriteLine("Employee Name: " + keyValuePair.Value.Name);
                Console.WriteLine("Employee Role: " + keyValuePair.Value.Role);
                Console.WriteLine("Employee Age: " + keyValuePair.Value.Age);
                Console.WriteLine("Employe Salary: " +keyValuePair.Value.Salary);
            }

            //now We will do Updaye,Remove And etc.



           










        }
    }
}