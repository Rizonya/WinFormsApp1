using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        ModelContext context;
        public Registration()
        {
            InitializeComponent();
            context = new ModelContext();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (context != null)
            {
                string username = usernametb.Text;
                string password = passwordtb.Text;
                User user = new User();
                user.Username = username;
                user.Password = password;
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                this.Close();


            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordtb.UseSystemPasswordChar = !passwordtb.UseSystemPasswordChar;
        }
    }
}
