namespace StudentNamespace
{
    public class StudentInfo
    {
        private string studentID;
        private string lastName;
        private string firstName;
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public StudentInfo() { }

        public StudentInfo(string studentID, string lastName, string firstName)
        {
            this.studentID = studentID;
            this.lastName = lastName;
            this.firstName = firstName;
        }
    }
}
