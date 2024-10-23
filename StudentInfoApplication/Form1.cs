using System;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(
                txtStudentID.Text,
                txtLastName.Text,
                txtFirstName.Text
            );
            lstStudentID.Items.Add(student.StudentID);
            lstFirstName.Items.Add(student.LastName);
            lstLastName.Items.Add(student.FirstName);
            txtStudentID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            StudentInfo student = new StudentInfo(
                txtStudentID.Text,
                txtLastName.Text,
                txtFirstName.Text
            );
            lstStudentID.Items.Add(student.StudentID);
            lstFirstName.Items.Add(student.LastName);
            lstLastName.Items.Add(student.FirstName);
            txtStudentID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
        }
    }
}
