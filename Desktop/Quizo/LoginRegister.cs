using Microsoft.Data.SqlClient;

namespace Quizo
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void loginDescription2_Click(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            signUp changeForm = new signUp();
            changeForm.Show();
            this.Hide();
        }

        private void LoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void login_Click(object sender, EventArgs e)
        {
            string email = loginEmail.Text.Trim();
            string password = loginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string connectionString = "Data Source=NAJIJRWAN\\MSSQLSERVER02;Initial Catalog=Quizo;Integrated Security=True;Trust Server Certificate=True";

            string query = "SELECT COUNT(*) FROM [User] WHERE Email = @Email AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful! Welcome back.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            main1 mainForm = new main1();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials! Please sign up or try a different email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = '*';
            toolTip1.SetToolTip(loginShowPassword, "Show password");
        }

        private void loginshowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (loginShowPassword.Checked)
            {
                loginPassword.PasswordChar = '\0';
            }
            else
            {
                loginPassword.PasswordChar = '*';
            }
        }
    }
}
