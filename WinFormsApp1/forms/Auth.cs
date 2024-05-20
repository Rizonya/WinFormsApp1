using WinFormsApp1.forms;
using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Auth : Form
    {
        ModelContext context;
        public Auth()
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
                User user = context.Users.FirstOrDefault(e => e.Username == username && e.Password == password);
                if (user != null)
                {
                    MessageBox.Show("Добро пожаловать, " + username);
                    Choose c = new Choose();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль");
                }


            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordtb.UseSystemPasswordChar = !passwordtb.UseSystemPasswordChar;
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
