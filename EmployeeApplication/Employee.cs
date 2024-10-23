using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string position;
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Employee() { }
        public Employee(int employeeId, string firstName, string lastName, string position)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}
