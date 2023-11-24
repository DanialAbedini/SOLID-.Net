using static SOLID.DIP;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle
            /*
            string email, password;
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            var user = new SRP.User
            {
                Password = password,
                Email = email,
            };

            var userService = new SRP.UserServices(user);

            userService.Register();
             */

            //////////////////////////////////////////////////////////////////////////

            //Open Closend Principle
            /*
            var rectangle =new  OCP.Rectangle(3,4);
            OCP.PrinterArea.Print(rectangle);
            var square = new OCP.Square(2);
            OCP.PrinterArea.Print(square);
            var circle = new OCP.Circle(3);
            OCP.PrinterArea.Print(circle);
            */

            //////////////////////////////////////////////////////////////////////////

            //Liskov Substitution Principal
            /*
            var collect =new LSP.Lists();
            collect.Add(2);
            collect.Show();
            */

            //////////////////////////////////////////////////////////////////////////

            //Interface segregation principle
            /*
            var programmer = new ISP.Programmer();
            programmer.WorkOnTask();
            var manager = new ISP.Manager();
            manager.AssignTask();
            manager.CreateSubTask();
            var teamlead = new ISP.TeamLead();
            teamlead.WorkOnTask();
            teamlead.AssignTask();
            teamlead.CreateSubTask();
            */

            //////////////////////////////////////////////////////////////////////////

            var employee = new Employee(new Salary());
            employee.PerHourMoney = 30;
            employee.HoursWorked = 150;
            Console.WriteLine($"Total Pays : {employee.GetSalary()}");

        }
    }
}
