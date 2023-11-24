using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IProgrammer
    {
        public abstract void WorkOnTask();
    }
    interface ILead
    {
        public abstract void AssignTask();
        public abstract void CreateSubTask();

    }
    public class ISP
    {
        public class Programmer : IProgrammer
        {

            public void WorkOnTask()
            {
                Console.WriteLine("Programmer Work On Task");

            }
        }
        public class Manager : ILead
        {
            public void AssignTask()
            {
                Console.WriteLine("Manager Assign Task");

            }

            public void CreateSubTask()
            {
                Console.WriteLine("Manger Create SubTask");

            }
        }
        public class TeamLead : ILead, IProgrammer
        {
            public void AssignTask()
            {
                Console.WriteLine("TeamLead Assign Task");
            }

            public void CreateSubTask()
            {
                Console.WriteLine("TeamLead Create SubTask");
            }

            public void WorkOnTask()
            {
                Console.WriteLine("TeamLead Work On Task");

            }
        }
    }
}
