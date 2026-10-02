namespace AshkanSocial.UI.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel brandPanel;
        private AshkanSocial.UI.Controls.AshkanLogo logo;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label brandSubtitle;
        private System.Windows.Forms.Label brandQuote;
        private AshkanSocial.UI.Controls.ModernPanel loginCard;
        private System.Windows.Forms.Label eyebrowLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeSubtitle;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private AshkanSocial.UI.Controls.ModernButton signInButton;
        private AshkanSocial.UI.Controls.ModernButton registerButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label demoLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.brandPanel = new System.Windows.Forms.Panel();
            this.logo = new AshkanSocial.UI.Controls.AshkanLogo();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandSubtitle = new System.Windows.Forms.Label();
            this.brandQuote = new System.Windows.Forms.Label();
            this.loginCard = new AshkanSocial.UI.Controls.ModernPanel();
            this.eyebrowLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeSubtitle = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new AshkanSocial.UI.Controls.ModernButton();
            this.registerButton = new AshkanSocial.UI.Controls.ModernButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.demoLabel = new System.Windows.Forms.Label();
            this.brandPanel.SuspendLayout();
            this.loginCard.SuspendLayout();
            this.SuspendLayout();

            this.brandPanel.BackColor = System.Drawing.Color.FromArgb(18, 38, 63);
            this.brandPanel.Controls.Add(this.brandQuote);
            this.brandPanel.Controls.Add(this.brandSubtitle);
            this.brandPanel.Controls.Add(this.brandLabel);
            this.brandPanel.Controls.Add(this.logo);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandPanel.Size = new System.Drawing.Size(420, 680);

            this.logo.Location = new System.Drawing.Point(139, 92);
            this.logo.Size = new System.Drawing.Size(112, 92);

            this.brandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.brandLabel.ForeColor = System.Drawing.Color.White;
            this.brandLabel.Location = new System.Drawing.Point(35, 196);
            this.brandLabel.Size = new System.Drawing.Size(320, 48);
            this.brandLabel.Text = "ASHKAN SOCIAL";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.brandSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandSubtitle.ForeColor = System.Drawing.Color.FromArgb(183, 198, 229);
            this.brandSubtitle.Location = new System.Drawing.Point(35, 244);
            this.brandSubtitle.Size = new System.Drawing.Size(320, 48);
            this.brandSubtitle.Text = "CONNECT  •  CREATE  •  BELONG\r\nA thoughtful desktop social experience";
            this.brandSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.brandQuote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.brandQuote.ForeColor = System.Drawing.Color.FromArgb(150, 169, 207);
            this.brandQuote.Location = new System.Drawing.Point(48, 520);
            this.brandQuote.Size = new System.Drawing.Size(294, 62);
            this.brandQuote.Text = "Built for meaningful conversations,\r\ncreative ideas and stronger communities.";
            this.brandQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.loginCard.BackColor = AshkanSocial.UI.Theme.ThemeColors.Surface;
            this.loginCard.BorderColor = AshkanSocial.UI.Theme.ThemeColors.BorderColor;
            this.loginCard.BorderRadius = 24;
            this.loginCard.BorderSize = 1;
            this.loginCard.Location = new System.Drawing.Point(470, 58);
            this.loginCard.Size = new System.Drawing.Size(460, 540);
            this.loginCard.Controls.Add(this.eyebrowLabel);
            this.loginCard.Controls.Add(this.welcomeLabel);
            this.loginCard.Controls.Add(this.welcomeSubtitle);
            this.loginCard.Controls.Add(this.usernameLabel);
            this.loginCard.Controls.Add(this.loginTextBox);
            this.loginCard.Controls.Add(this.passwordLabel);
            this.loginCard.Controls.Add(this.passwordTextBox);
            this.loginCard.Controls.Add(this.signInButton);
            this.loginCard.Controls.Add(this.registerButton);
            this.loginCard.Controls.Add(this.statusLabel);
            this.loginCard.Controls.Add(this.demoLabel);

            this.eyebrowLabel.AutoSize = true;
            this.eyebrowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.eyebrowLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.Primary;
            this.eyebrowLabel.Location = new System.Drawing.Point(35, 34);
            this.eyebrowLabel.Text = "WELCOME TO ASHKAN SOCIAL";

            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.TextPrimary;
            this.welcomeLabel.Location = new System.Drawing.Point(32, 61);
            this.welcomeLabel.Text = "Welcome back";

            this.welcomeSubtitle.AutoSize = true;
            this.welcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.welcomeSubtitle.ForeColor = AshkanSocial.UI.Theme.ThemeColors.TextMuted;
            this.welcomeSubtitle.Location = new System.Drawing.Point(36, 112);
            this.welcomeSubtitle.Text = "Sign in to continue to your community.";

            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.TextSecondary;
            this.usernameLabel.Location = new System.Drawing.Point(35, 158);
            this.usernameLabel.Text = "Username or email";
            this.loginTextBox.Location = new System.Drawing.Point(35, 187);
            this.loginTextBox.Size = new System.Drawing.Size(370, 30);
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.TextSecondary;
            this.passwordLabel.Location = new System.Drawing.Point(35, 239);
            this.passwordLabel.Text = "Password";
            this.passwordTextBox.Location = new System.Drawing.Point(35, 268);
            this.passwordTextBox.Size = new System.Drawing.Size(370, 30);
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.UseSystemPasswordChar = true;

            this.signInButton.Location = new System.Drawing.Point(35, 330);
            this.signInButton.Size = new System.Drawing.Size(370, 48);
            this.signInButton.Text = "Sign In";
            this.signInButton.BackColor = AshkanSocial.UI.Theme.ThemeColors.Primary;
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.BorderRadius = 14;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);

            this.registerButton.Location = new System.Drawing.Point(35, 389);
            this.registerButton.Size = new System.Drawing.Size(370, 45);
            this.registerButton.Text = "Create New Account";
            this.registerButton.BackColor = AshkanSocial.UI.Theme.ThemeColors.Secondary;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.BorderRadius = 14;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);

            this.statusLabel.Location = new System.Drawing.Point(35, 444);
            this.statusLabel.Size = new System.Drawing.Size(370, 30);
            this.statusLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.AlertRed;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.demoLabel.Location = new System.Drawing.Point(35, 477);
            this.demoLabel.Size = new System.Drawing.Size(370, 22);
            this.demoLabel.Text = "Portfolio demo  •  ashkan / 123456";
            this.demoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.demoLabel.ForeColor = AshkanSocial.UI.Theme.ThemeColors.TextMuted;

            this.AcceptButton = this.signInButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AshkanSocial.UI.Theme.ThemeColors.Background;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.loginCard);
            this.Controls.Add(this.brandPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ashkan Social — Sign in";
            this.brandPanel.ResumeLayout(false);
            this.loginCard.ResumeLayout(false);
            this.loginCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
