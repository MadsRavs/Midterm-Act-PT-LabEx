using System.Configuration;

namespace StudentRegistrationApplication
{
    public partial class RegistrationForm : Form
    {

        string first_name, middle_name, last_name;
        int day, month, year;
        bool isMale;
        bool isFemale;
        bool isOthers;
        string gender;
        string program;
        public RegistrationForm()
        {
            InitializeComponent();
        }



        // Closes the Application when clicking the X
        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When clicking the register button

        public void setDefaultValue()
        {
            // Default Value for Day Combobox
            DayCombobox.Items.Insert(0, "-Day-");
            DayCombobox.SelectedIndex = 0;

            // Default Value for Month Combobox
            monthCombobox.Items.Insert(0, "-Month-");
            monthCombobox.SelectedIndex = 0;

            // Default Value for Year Combobox
            YearCombobox.Items.Insert(0, "-Year-");
            YearCombobox.SelectedIndex = 0;
        }
        public void populateDay()
        {
            for (int x = 1; x <= 31; x++) DayCombobox.Items.Add(x);
        }

        public void populateMonth()
        {
            for (int x = 1; x <= 12; x++) monthCombobox.Items.Add(x);
        }
        public void populateYear()
        {
            for (int x = 1900; x <= DateTime.Now.Year; x++) YearCombobox.Items.Add(x);
        }

        public void getData()
        {
            first_name = FirstNameTextbox.Text;
            middle_name = MiddleNameTextbox.Text;
            last_name = LastNameTextbox.Text;

            checkNull(first_name);
            checkNull(middle_name);
            checkNull(last_name);

            day = Int32.Parse(DayCombobox.Text);
            month = Int32.Parse(monthCombobox.Text);
            year = Int32.Parse(YearCombobox.Text);

            if (!int.TryParse(DayCombobox.SelectedItem?.ToString(), out day) ||
               !int.TryParse(monthCombobox.SelectedItem?.ToString(), out month) ||
               !int.TryParse(YearCombobox.SelectedItem?.ToString(), out year))
            {
                throw new Exception("Please select valid date.");
            }

            program = ProgramCombobox.Text.Trim();
            gender = getGender();
        }

        private string getGender()
        {
            if (MaleRadiobutton.Checked) return "Male";
            if (FemaleRadiobutton.Checked) return "Female";
            return "Other";
        }

        public void checkNull(string data)
        {
            if (data == null || data.Trim() == "") throw new Exception();
        }



        public void Output(string lastName, string firstName, string middleName, int day, int month, int year)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nDate of birth: {month}/{day}/{year}");
        }

        public void Output(string lastName, string firstName, string middleName, string program)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nCourse: {program}");
        }

        public void Output(string lastName, string firstName, string middleName, string gender, int day, int month, int year)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nGender: {gender}\nDate of birth: {month}/{day}/{year}");
        }

        private void RegisterNow_Click_1(object sender, EventArgs e)
        {
            try
            {
                getData();
                Output(last_name, first_name, middle_name, day, month, year);
                clearInputFields();
                Output(last_name, first_name, middle_name, program);
                clearInputFields();
                Output(last_name, first_name, middle_name, gender, day, month, year);
                clearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearInputFields()
        {
            FirstNameTextbox.Text = string.Empty;
            LastNameTextbox.Text = string.Empty;
            MiddleNameTextbox.Text = string.Empty;

            MaleRadiobutton.Checked = false;
            FemaleRadiobutton.Checked = false;
            OtherRadiobutton.Checked = false;

            DayCombobox.Text = string.Empty;
            monthCombobox.Text = string.Empty;
            YearCombobox.Text = string.Empty;
            ProgramCombobox.Text = string.Empty;

        }

        private void RegistrationForm_Load_1(object sender, EventArgs e)
        {
            setDefaultValue();
            populateDay();
            populateMonth();
            populateYear();
        }
    }
}
