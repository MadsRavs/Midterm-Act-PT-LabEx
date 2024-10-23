using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double RatePerHour { get; set; }

        public double ComputeSalary()
        {
            return HoursWorked * RatePerHour;
        }
    }
}
