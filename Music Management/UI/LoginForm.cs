using Music_Management.Helpers;
namespace Music_Management.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "admin" && pass == "admin")
            {
                var main = new MainForm("admin");
                main.Show();
                this.Hide();
            }
            else if (user == "user" && pass == "user")
            {
                var main = new MainForm("user");
                main.Show();
                this.Hide();
            }
            else
            {
                Utils.ShowWarning("Tài khoản không hợp lệ!");
            }
        }
    }
}