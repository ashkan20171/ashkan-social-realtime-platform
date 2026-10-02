namespace AshkanSocial.UI.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label headingLabel, nameLabel, usernameLabel, emailLabel, passwordLabel, confirmLabel, statusLabel;
        private System.Windows.Forms.TextBox nameTextBox, usernameTextBox, emailTextBox, passwordTextBox, confirmTextBox;
        private AshkanSocial.UI.Controls.ModernButton createAccountButton;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.headingLabel=new System.Windows.Forms.Label(); this.nameLabel=new System.Windows.Forms.Label(); this.usernameLabel=new System.Windows.Forms.Label(); this.emailLabel=new System.Windows.Forms.Label(); this.passwordLabel=new System.Windows.Forms.Label(); this.confirmLabel=new System.Windows.Forms.Label(); this.statusLabel=new System.Windows.Forms.Label();
            this.nameTextBox=new System.Windows.Forms.TextBox(); this.usernameTextBox=new System.Windows.Forms.TextBox(); this.emailTextBox=new System.Windows.Forms.TextBox(); this.passwordTextBox=new System.Windows.Forms.TextBox(); this.confirmTextBox=new System.Windows.Forms.TextBox(); this.createAccountButton=new AshkanSocial.UI.Controls.ModernButton();
            this.SuspendLayout();
            this.headingLabel.AutoSize=true; this.headingLabel.Font=new System.Drawing.Font("Segoe UI",18F,System.Drawing.FontStyle.Bold); this.headingLabel.ForeColor=AshkanSocial.UI.Theme.ThemeColors.TextPrimary; this.headingLabel.Location=new System.Drawing.Point(55,35); this.headingLabel.Text="Create your Ashkan Social account";
            SetupLabel(this.nameLabel,"Full name",45,80); SetupText(this.nameTextBox,45,105); SetupLabel(this.usernameLabel,"Username",45,162); SetupText(this.usernameTextBox,45,187); SetupLabel(this.emailLabel,"Email",45,244); SetupText(this.emailTextBox,45,269); SetupLabel(this.passwordLabel,"Password (at least 6 characters)",45,326); SetupText(this.passwordTextBox,45,351); this.passwordTextBox.UseSystemPasswordChar=true; SetupLabel(this.confirmLabel,"Confirm password",45,408); SetupText(this.confirmTextBox,45,433); this.confirmTextBox.UseSystemPasswordChar=true;
            this.createAccountButton.Location=new System.Drawing.Point(45,500); this.createAccountButton.Size=new System.Drawing.Size(375,44); this.createAccountButton.Text="Create Account"; this.createAccountButton.BackColor=AshkanSocial.UI.Theme.ThemeColors.Primary; this.createAccountButton.ForeColor=System.Drawing.Color.White; this.createAccountButton.BorderRadius=12; this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            this.statusLabel.Location=new System.Drawing.Point(45,560); this.statusLabel.Size=new System.Drawing.Size(375,50); this.statusLabel.ForeColor=AshkanSocial.UI.Theme.ThemeColors.AlertRed;
            this.AcceptButton=this.createAccountButton; this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font; this.BackColor=AshkanSocial.UI.Theme.ThemeColors.Background; this.Padding=new System.Windows.Forms.Padding(10); this.ClientSize=new System.Drawing.Size(500,630); this.Controls.AddRange(new System.Windows.Forms.Control[]{this.headingLabel,this.nameLabel,this.nameTextBox,this.usernameLabel,this.usernameTextBox,this.emailLabel,this.emailTextBox,this.passwordLabel,this.passwordTextBox,this.confirmLabel,this.confirmTextBox,this.createAccountButton,this.statusLabel}); this.Font=new System.Drawing.Font("Segoe UI",10F); this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox=false; this.StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; this.Text="Create Account · Ashkan Social"; this.ResumeLayout(false); this.PerformLayout();
        }
        private void SetupLabel(System.Windows.Forms.Label l,string text,int x,int y){l.AutoSize=true;l.Text=text;l.Location=new System.Drawing.Point(x,y);l.ForeColor=AshkanSocial.UI.Theme.ThemeColors.TextSecondary;}
        private void SetupText(System.Windows.Forms.TextBox t,int x,int y){t.Location=new System.Drawing.Point(x,y);t.Size=new System.Drawing.Size(375,25);}
    }
}
