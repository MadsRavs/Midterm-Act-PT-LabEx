using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private List<Employee> employees = new List<Employee>();
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(txtEmployeeId.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string position = txtPosition.Text;
            Employee newEmployee = new Employee(employeeId, firstName, lastName, position);
            employees.Add(newEmployee);
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = employees;

            txtEmployeeId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
        }
        private void frmEmployeeDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddEmployee.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
