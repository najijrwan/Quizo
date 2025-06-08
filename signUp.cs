using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Quizo
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Load(object sender, EventArgs e)
        {
            ptb.PasswordChar = '*';
            cptb.PasswordChar = '*';
            toolTip1.SetToolTip(showPassword, "Show password");
            toolTip1.SetToolTip(showConfirmPassword, "Show password");
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                ptb.PasswordChar = '\0';
            }
            else
            {
                ptb.PasswordChar = '*';
            }
        }
        private void showConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showConfirmPassword.Checked)
            {
                cptb.PasswordChar = '\0';
            }
            else
            {
                cptb.PasswordChar = '*';
            }
        }

        private void signUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signUp2_Click(object sender, EventArgs e)
        {
            string firstName = fntb.Text.Trim();
            string lastName = lntb.Text.Trim();
            string email = etb.Text.Trim();
            string password = ptb.Text.Trim();
            string confirmPassword = cptb.Text.Trim();
            int age = (int)atb.Value;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill out all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8 ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]") ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]") ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"\d") ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*]"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character (!@#$%^&*).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=NAJIJRWAN\\MSSQLSERVER02;Initial Catalog=Quizo;Integrated Security=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string checkEmailQuery = "SELECT COUNT(*) FROM [User] WHERE Email = @Email";

                    using (SqlCommand checkEmailCommand = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        int emailExists = (int)checkEmailCommand.ExecuteScalar();

                        if (emailExists > 0)
                        {
                            MessageBox.Show("This email already exists. Please log in or try a different email.",
                                "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "INSERT INTO [User] (FirstName, LastName, Age, Email, Password) VALUES (@FirstName, @LastName, @Age, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration successful! You can now begin the quiz!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginRegister loginRegisterForm = new LoginRegister();
                        main1 main1 = new main1();
                        main1.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            LoginRegister changeForm = new LoginRegister();
            changeForm.Show();
            this.Hide();
        }

        private void ptb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
