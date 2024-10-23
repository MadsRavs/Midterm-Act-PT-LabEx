using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    public interface IEmployee
    {
        string Name { get; set; }
        int HoursWorked { get; set; }
        double RatePerHour { get; set; }

        double ComputeSalary();
    }
}

