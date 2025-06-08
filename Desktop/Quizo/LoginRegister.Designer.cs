namespace Quizo
{
    partial class LoginRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            email = new Label();
            password = new Label();
            loginDescription = new Label();
            panel1 = new Panel();
            loginShowPassword = new CheckBox();
            loginPassword = new TextBox();
            loginEmail = new TextBox();
            signUp = new Button();
            login = new Button();
            loginDescription2 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            email.ForeColor = Color.ForestGreen;
            email.Location = new Point(25, 32);
            email.Name = "email";
            email.Size = new Size(56, 20);
            email.TabIndex = 0;
            email.Text = "E-mail";
            email.Click += email_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password.ForeColor = Color.ForestGreen;
            password.Location = new Point(25, 107);
            password.Name = "password";
            password.Size = new Size(77, 20);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Click += password_Click;
            // 
            // loginDescription
            // 
            loginDescription.AutoSize = true;
            loginDescription.BackColor = Color.Honeydew;
            loginDescription.BorderStyle = BorderStyle.FixedSingle;
            loginDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginDescription.ForeColor = Color.ForestGreen;
            loginDescription.Location = new Point(610, 102);
            loginDescription.Name = "loginDescription";
            loginDescription.Size = new Size(334, 22);
            loginDescription.TabIndex = 2;
            loginDescription.Text = "To access your account enter your credentials";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(loginShowPassword);
            panel1.Controls.Add(loginPassword);
            panel1.Controls.Add(loginEmail);
            panel1.Controls.Add(email);
            panel1.Controls.Add(password);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(541, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 160);
            panel1.TabIndex = 3;
            // 
            // loginShowPassword
            // 
            loginShowPassword.AutoSize = true;
            loginShowPassword.BackColor = Color.LightGoldenrodYellow;
            loginShowPassword.Cursor = Cursors.Hand;
            loginShowPassword.ForeColor = Color.Transparent;
            loginShowPassword.Location = new Point(423, 110);
            loginShowPassword.Name = "loginShowPassword";
            loginShowPassword.Size = new Size(18, 17);
            loginShowPassword.TabIndex = 21;
            loginShowPassword.UseVisualStyleBackColor = false;
            loginShowPassword.CheckedChanged += loginshowPassword_CheckedChanged;
            // 
            // loginPassword
            // 
            loginPassword.BackColor = Color.Honeydew;
            loginPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginPassword.ForeColor = Color.LightSeaGreen;
            loginPassword.Location = new Point(114, 104);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(327, 27);
            loginPassword.TabIndex = 3;
            // 
            // loginEmail
            // 
            loginEmail.BackColor = Color.Honeydew;
            loginEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginEmail.ForeColor = Color.LightSeaGreen;
            loginEmail.Location = new Point(114, 29);
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(327, 27);
            loginEmail.TabIndex = 2;
            // 
            // signUp
            // 
            signUp.BackColor = Color.Honeydew;
            signUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUp.ForeColor = Color.ForestGreen;
            signUp.Location = new Point(850, 335);
            signUp.Name = "signUp";
            signUp.Size = new Size(94, 31);
            signUp.TabIndex = 7;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // login
            // 
            login.BackColor = Color.Honeydew;
            login.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login.ForeColor = Color.ForestGreen;
            login.Location = new Point(631, 335);
            login.Name = "login";
            login.Size = new Size(94, 31);
            login.TabIndex = 4;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // loginDescription2
            // 
            loginDescription2.AutoSize = true;
            loginDescription2.BackColor = Color.Honeydew;
            loginDescription2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginDescription2.ForeColor = Color.ForestGreen;
            loginDescription2.Location = new Point(774, 340);
            loginDescription2.Name = "loginDescription2";
            loginDescription2.Size = new Size(26, 20);
            loginDescription2.TabIndex = 6;
            loginDescription2.Text = "Or";
            loginDescription2.Click += loginDescription2_Click;
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImage = Properties.Resources.quiz;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1034, 503);
            Controls.Add(signUp);
            Controls.Add(panel1);
            Controls.Add(loginDescription2);
            Controls.Add(login);
            Controls.Add(loginDescription);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizo | Log In";
            FormClosed += LoginRegister_FormClosed;
            Load += LoginRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label email;
        private Label password;
        private Label loginDescription;
        private Panel panel1;
        private TextBox loginPassword;
        private TextBox loginEmail;
        private Button login;
        private Label label1;
        private Label loginDescription2;
        private Button signUp;
        private CheckBox loginShowPassword;
        private ToolTip toolTip1;
    }
}
