using System;using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AshkanSocial.Core.Models;
using AshkanSocial.Core.Services;

namespace AshkanSocial.UI.Forms
{
    public partial class RegisterForm : Form
    {
        public string RegisteredUsername { get; private set; }
        public RegisterForm() { InitializeComponent();BackgroundService.Apply(this,"Register"); }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string un = usernameTextBox.Text.Trim();
            string validationError = ValidationService.ValidateRegistration(nameTextBox.Text, un, emailTextBox.Text, passwordTextBox.Text, confirmTextBox.Text);
            if (validationError != null) { statusLabel.Text = validationError; return; }
            var d = DataService.Instance;
            if (d.Data.Users.Any(x => x.Username.Equals(un, StringComparison.OrdinalIgnoreCase) || x.Email.Equals(emailTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))) { statusLabel.Text = "Username or email is already registered."; return; }
            string h, s; SecurityService.CreatePasswordHash(passwordTextBox.Text, out h, out s);
            d.Data.Users.Add(new User { Id = Guid.NewGuid().ToString(), FullName = nameTextBox.Text.Trim(), Username = un, Email = emailTextBox.Text.Trim(), PasswordHash = h, PasswordSalt = s, CreatedAt = DateTime.Now, Bio = "New Ashkan Social member" });
            d.Save(); RegisteredUsername = un; DialogResult = DialogResult.OK; Close();
        }
    }
}
