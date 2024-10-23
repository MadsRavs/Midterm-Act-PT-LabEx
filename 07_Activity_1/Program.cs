using System.Data;
namespace usernamespace {
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }
        public bool verifyLogin(string id, string pass)
        {
            return this.user_id.Equals(id) && this.user_password.Equals(pass);
        }

        public abstract void updatePassword(string newpassword);
    }
    public class Administrator:User
    {
        private string admin_name;
        public Administrator(string name, string id, string pass): base(id, pass) 
        {
            this.admin_name = name;
        }
        public override void updatePassword(string newpassword)
        {
            this.user_password = newpassword;
            Console.WriteLine("Password updated successfully");
        }

        public void updateAdminName(string name) 
        {
            this.admin_name = name;
            Console.WriteLine("Admin name updated successfully.");
        }

        public void displayAdminDetails()
        {
            Console.WriteLine($"Admin name: {admin_name}");
            Console.WriteLine($"User ID:  {user_password}");
        }
    } 
    class StartProgram
    {
        static void Main(string[] args)
        {
            Administrator a = new Administrator("Travis","007","POGIAKO123");

            Console.WriteLine(a.verifyLogin("007", "POGIAKO123") ? "Login successful!" : "Login failed!");

            a.updateAdminName("Amado");
            a.updatePassword("Password");
            a.displayAdminDetails();
        }
    }
}
