using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Code
{
    public partial class FormLogin : Form
    {
        public AppUser user = new AppUser();
        public FormLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Username;
            string pass;
            FakeAppUserRepository repository = new FakeAppUserRepository();
            bool auth = false;

            Username = UserName_txt.Text.ToString();
            pass = Password_txt.Text.ToString();
            auth = repository.Login(Username, pass);
            if (auth)
            {
                repository.SetAuthenticated(Username, auth);
                user = repository.GetbyUserName(Username);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Attention");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
