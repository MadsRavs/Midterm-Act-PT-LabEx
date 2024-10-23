using EmployeeNamespace;
using System.Xml.Linq;

namespace EmployeeApplication_2
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee employee = new PartTimeEmployee
            {
                Name = txt_firstname.Text + txt_lastname.Text,
                HoursWorked = int.Parse(txt_thw.Text),
                RatePerHour = double.Parse(txt_rph.Text)
            };
            double salary = employee.ComputeSalary();

            lbl_firstname.Text = txt_firstname.Text.ToString();
            lbl_lastname.Text = txt_lastname.Text.ToString();
            lbl_salary.Text = salary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txt_thw) 
                {
                    button1.PerformClick(); 
                }
                else
                {
                    Control nextControl = GetNextTextBox((Control)sender);
                    if (nextControl != null)
                    {
                        nextControl.Focus();
                    }
                }
                e.SuppressKeyPress = true; 
            }
        }

        private Control GetNextTextBox(Control current)
        {
            Control next = this.GetNextControl(current, true);
            while (next != null && !(next is TextBox))
            {
                next = this.GetNextControl(next, true);
            }
            return next;
        }
    }
}
