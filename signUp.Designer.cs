namespace Quizo
{
    partial class signUp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            signUpDescription = new Label();
            singUpFName = new Label();
            signUpLName = new Label();
            age = new Label();
            signUpEmail = new Label();
            signUpPassword = new Label();
            lntb = new TextBox();
            etb = new TextBox();
            ptb = new TextBox();
            fntb = new TextBox();
            confirmPassword = new Label();
            cptb = new TextBox();
            signUp2 = new Button();
            loginDescription2 = new Label();
            goBack = new Button();
            atb = new NumericUpDown();
            showPassword = new CheckBox();
            showConfirmPassword = new CheckBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)atb).BeginInit();
            SuspendLayout();
            // 
            // signUpDescription
            // 
            signUpDescription.AutoSize = true;
            signUpDescription.BackColor = Color.Honeydew;
            signUpDescription.BorderStyle = BorderStyle.FixedSingle;
            signUpDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUpDescription.ForeColor = Color.ForestGreen;
            signUpDescription.Location = new Point(114, 24);
            signUpDescription.Name = "signUpDescription";
            signUpDescription.Size = new Size(140, 22);
            signUpDescription.TabIndex = 3;
            signUpDescription.Text = "Create an account";
            // 
            // singUpFName
            // 
            singUpFName.AutoSize = true;
            singUpFName.BackColor = Color.Honeydew;
            singUpFName.BorderStyle = BorderStyle.FixedSingle;
            singUpFName.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            singUpFName.ForeColor = Color.Black;
            singUpFName.Location = new Point(12, 81);
            singUpFName.Name = "singUpFName";
            singUpFName.Size = new Size(94, 22);
            singUpFName.TabIndex = 4;
            singUpFName.Text = "First Name:";
            // 
            // signUpLName
            // 
            signUpLName.AutoSize = true;
            signUpLName.BackColor = Color.Honeydew;
            signUpLName.BorderStyle = BorderStyle.FixedSingle;
            signUpLName.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUpLName.ForeColor = Color.Black;
            signUpLName.Location = new Point(14, 136);
            signUpLName.Name = "signUpLName";
            signUpLName.Size = new Size(92, 22);
            signUpLName.TabIndex = 5;
            signUpLName.Text = "Last Name:";
            // 
            // age
            // 
            age.AutoSize = true;
            age.BackColor = Color.Honeydew;
            age.BorderStyle = BorderStyle.FixedSingle;
            age.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            age.ForeColor = Color.Black;
            age.Location = new Point(14, 191);
            age.Name = "age";
            age.Size = new Size(43, 22);
            age.TabIndex = 6;
            age.Text = "Age:";
            // 
            // signUpEmail
            // 
            signUpEmail.AutoSize = true;
            signUpEmail.BackColor = Color.Honeydew;
            signUpEmail.BorderStyle = BorderStyle.FixedSingle;
            signUpEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUpEmail.ForeColor = Color.Black;
            signUpEmail.Location = new Point(14, 246);
            signUpEmail.Name = "signUpEmail";
            signUpEmail.Size = new Size(62, 22);
            signUpEmail.TabIndex = 7;
            signUpEmail.Text = "E-mail:";
            // 
            // signUpPassword
            // 
            signUpPassword.AutoSize = true;
            signUpPassword.BackColor = Color.Honeydew;
            signUpPassword.BorderStyle = BorderStyle.FixedSingle;
            signUpPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUpPassword.ForeColor = Color.Black;
            signUpPassword.Location = new Point(14, 301);
            signUpPassword.Name = "signUpPassword";
            signUpPassword.Size = new Size(83, 22);
            signUpPassword.TabIndex = 8;
            signUpPassword.Text = "Password:";
            // 
            // lntb
            // 
            lntb.BackColor = Color.Honeydew;
            lntb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lntb.ForeColor = Color.LightSeaGreen;
            lntb.Location = new Point(14, 161);
            lntb.Name = "lntb";
            lntb.Size = new Size(327, 27);
            lntb.TabIndex = 10;
            // 
            // etb
            // 
            etb.BackColor = Color.Honeydew;
            etb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            etb.ForeColor = Color.LightSeaGreen;
            etb.Location = new Point(14, 271);
            etb.Name = "etb";
            etb.Size = new Size(327, 27);
            etb.TabIndex = 11;
            etb.TextChanged += textBox3_TextChanged;
            // 
            // ptb
            // 
            ptb.BackColor = Color.Honeydew;
            ptb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ptb.ForeColor = Color.LightSeaGreen;
            ptb.Location = new Point(14, 326);
            ptb.Name = "ptb";
            ptb.Size = new Size(327, 27);
            ptb.TabIndex = 12;
            ptb.TextChanged += ptb_TextChanged;
            // 
            // fntb
            // 
            fntb.BackColor = Color.Honeydew;
            fntb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            fntb.ForeColor = Color.LightSeaGreen;
            fntb.Location = new Point(12, 106);
            fntb.Name = "fntb";
            fntb.Size = new Size(329, 27);
            fntb.TabIndex = 13;
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.BackColor = Color.Honeydew;
            confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            confirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            confirmPassword.ForeColor = Color.Black;
            confirmPassword.Location = new Point(14, 356);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(146, 22);
            confirmPassword.TabIndex = 14;
            confirmPassword.Text = "Confirm Password:";
            // 
            // cptb
            // 
            cptb.BackColor = Color.Honeydew;
            cptb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cptb.ForeColor = Color.LightSeaGreen;
            cptb.Location = new Point(14, 381);
            cptb.Name = "cptb";
            cptb.Size = new Size(327, 27);
            cptb.TabIndex = 15;
            cptb.TextChanged += textBox6_TextChanged;
            // 
            // signUp2
            // 
            signUp2.BackColor = Color.Honeydew;
            signUp2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUp2.ForeColor = Color.ForestGreen;
            signUp2.Location = new Point(59, 414);
            signUp2.Name = "signUp2";
            signUp2.Size = new Size(94, 30);
            signUp2.TabIndex = 16;
            signUp2.Text = "Sign up";
            signUp2.UseVisualStyleBackColor = false;
            signUp2.Click += signUp2_Click;
            // 
            // loginDescription2
            // 
            loginDescription2.AutoSize = true;
            loginDescription2.BackColor = Color.Honeydew;
            loginDescription2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginDescription2.ForeColor = Color.ForestGreen;
            loginDescription2.Location = new Point(159, 419);
            loginDescription2.Name = "loginDescription2";
            loginDescription2.Size = new Size(26, 20);
            loginDescription2.TabIndex = 17;
            loginDescription2.Text = "Or";
            // 
            // goBack
            // 
            goBack.BackColor = Color.Honeydew;
            goBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            goBack.ForeColor = Color.ForestGreen;
            goBack.Location = new Point(191, 414);
            goBack.Name = "goBack";
            goBack.Size = new Size(94, 30);
            goBack.TabIndex = 18;
            goBack.Text = "Go back";
            goBack.UseVisualStyleBackColor = false;
            goBack.Click += goBack_Click;
            // 
            // atb
            // 
            atb.ForeColor = Color.LightSeaGreen;
            atb.Location = new Point(14, 216);
            atb.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            atb.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            atb.Name = "atb";
            atb.Size = new Size(327, 27);
            atb.TabIndex = 19;
            atb.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.BackColor = Color.LightGoldenrodYellow;
            showPassword.ForeColor = Color.Transparent;
            showPassword.Location = new Point(323, 332);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(18, 17);
            showPassword.TabIndex = 20;
            showPassword.UseVisualStyleBackColor = false;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // showConfirmPassword
            // 
            showConfirmPassword.AutoSize = true;
            showConfirmPassword.BackColor = Color.LightGoldenrodYellow;
            showConfirmPassword.ForeColor = Color.Transparent;
            showConfirmPassword.Location = new Point(323, 387);
            showConfirmPassword.Name = "showConfirmPassword";
            showConfirmPassword.Size = new Size(18, 17);
            showConfirmPassword.TabIndex = 21;
            showConfirmPassword.UseVisualStyleBackColor = false;
            showConfirmPassword.CheckedChanged += showConfirmPassword_CheckedChanged;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(355, 474);
            Controls.Add(showConfirmPassword);
            Controls.Add(showPassword);
            Controls.Add(atb);
            Controls.Add(goBack);
            Controls.Add(loginDescription2);
            Controls.Add(signUp2);
            Controls.Add(cptb);
            Controls.Add(confirmPassword);
            Controls.Add(fntb);
            Controls.Add(ptb);
            Controls.Add(etb);
            Controls.Add(lntb);
            Controls.Add(signUpPassword);
            Controls.Add(signUpEmail);
            Controls.Add(age);
            Controls.Add(signUpLName);
            Controls.Add(singUpFName);
            Controls.Add(signUpDescription);
            Cursor = Cursors.Hand;
            ForeColor = Color.LightSeaGreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "signUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizo | Sign Up";
            FormClosed += signUp_FormClosed;
            Load += signUp_Load;
            ((System.ComponentModel.ISupportInitialize)atb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUpDescription;
        private Label singUpFName;
        private Label signUpLName;
        private Label age;
        private Label signUpEmail;
        private Label signUpPassword;
        private TextBox lntb;
        private TextBox etb;
        private TextBox ptb;
        private TextBox fntb;
        private Label confirmPassword;
        private TextBox cptb;
        private Button signUp2;
        private Label loginDescription2;
        private Button goBack;
        private NumericUpDown atb;
        private CheckBox showPassword;
        private CheckBox showConfirmPassword;
        private ToolTip toolTip1;
    }
}