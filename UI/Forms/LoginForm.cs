using System;using System.IO;
using System.Drawing;
using System.Windows.Forms;
using AshkanSocial.Core.Services;

namespace AshkanSocial.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();BackgroundService.Apply(this,"Login");
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            var u = DataService.Instance.FindLogin(loginTextBox.Text.Trim());
            if (u == null || !SecurityService.Verify(passwordTextBox.Text, u.PasswordHash, u.PasswordSalt))
            {
                statusLabel.Text = "Incorrect username/email or password.";
                return;
            }

            Session.CurrentUser = u;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var f = new RegisterForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loginTextBox.Text = f.RegisteredUsername;
                    passwordTextBox.Focus();
                }
            }
        }
    }
}
