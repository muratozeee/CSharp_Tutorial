namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {

            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            IPersonManager internEmployee = new InternEmployee();

            projectManager.Add(employeeManager);
            projectManager.Add(customerManager);
            projectManager.Add(internEmployee);

            projectManager.Update(employeeManager);

          





        }

        interface IPersonManager {

            //implemented Operation.

            void Add();
            void Update();

        }
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Customer was Added..!");
            }

            public void Update()
            {
                Console.WriteLine("Customer was Updated..!");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Employee was Added..!");
            }

            public void Update()
            {
                Console.WriteLine("Employee was Updated..!");
            }
        }

        class ProjectManager
        {

            public void Add(IPersonManager personManager)
            {
                personManager.Add();

            }

            public void Update(IPersonManager personManager)
            {

                personManager.Update();
            }
        }
        class InternEmployee : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Intern was Added..!");
            }

            public void Update()
            {
                Console.WriteLine("Intern was Updated..!");
            }
        }


    }
}