namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.CustomizableEdges = customizableEdges1;
            txtBoxUserName.DefaultText = "";
            txtBoxUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxUserName.Font = new Font("Segoe UI", 9F);
            txtBoxUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxUserName.Location = new Point(306, 134);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.PlaceholderText = "Enter username";
            txtBoxUserName.SelectedText = "";
            txtBoxUserName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBoxUserName.Size = new Size(200, 36);
            txtBoxUserName.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.CustomizableEdges = customizableEdges3;
            txtBoxPassword.DefaultText = "";
            txtBoxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxPassword.Font = new Font("Segoe UI", 9F);
            txtBoxPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxPassword.Location = new Point(306, 210);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PlaceholderText = "Enter password";
            txtBoxPassword.SelectedText = "";
            txtBoxPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBoxPassword.Size = new Size(200, 36);
            txtBoxPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(306, 278);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(200, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16F);
            guna2HtmlLabel1.Location = new Point(306, 68);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(186, 32);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Login Your Account";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 11F);
            guna2HtmlLabel2.Location = new Point(306, 40);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(70, 22);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUserName);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBoxUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}