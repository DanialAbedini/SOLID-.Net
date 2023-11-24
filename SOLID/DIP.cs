using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float PerMoneyHour);
    }
    public class DIP
    {
        public class Salary : ISalaryCalculator
        {
            public float CalculateSalary(int hoursWorked, float PerMoneyHour) => hoursWorked * PerMoneyHour;
        }
        public class Employee
        {
            private readonly ISalaryCalculator _salaryCalculator;
            public int HoursWorked { get; set; }
            public int PerHourMoney { get; set; }
            public Employee(ISalaryCalculator salaryCalculator)
            {
                _salaryCalculator = salaryCalculator;
            }
            public float GetSalary()
            {
                return _salaryCalculator.CalculateSalary(HoursWorked, PerHourMoney);
            }
        }
    }
}
