using BankSystems;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void Login_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
            //Conns.Open();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accNumber = txtbaccountnumber.Text; // Assuming 'acc' is a TextBox control for entering the account number
            string gmail = txtbGmail.Text; // Assuming 'gm' is a TextBox control for entering the Gmail address
            string enteredPassword = txtbpassword.Text; // Assuming 'password' is a TextBox control for entering the password

            // Perform the database query to check if the account exists and the password matches
            string query = "SELECT Password FROM Accounts WHERE Acc_Number = @AccNumber AND Gmail = @Gmail";
          
                using (SqlCommand command = new SqlCommand(query, Conns))
                {
                    command.Parameters.AddWithValue("@AccNumber", accNumber);
                    command.Parameters.AddWithValue("@Gmail", gmail);

                    Conns.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string storedPassword = reader.GetString(0);

                        if (enteredPassword == storedPassword)
                    {
                        
                         Form parentForm = this.ParentForm;
                         parentForm.Hide();
                         SignUp signUp = new SignUp();
                         Conns.Close();
                         AccountProfile usersMenu = new AccountProfile();
                        signUp.Dashbourdd.Controls.Add(usersMenu);
                         signUp.Show();

                    }
                        else
                        {
                            // Password doesn't match
                            MessageBox.Show("Invalid password!");
                        }
                    }
                    else
                    {
                        // Account not found
                        MessageBox.Show("Account not found!");
                    }

                    reader.Close();
               
            }
            Conns.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbaccountnumber.Text = string.Empty;
            txtbpassword.Text = string.Empty;
            txtbGmail.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receiptss receiptss = new Receiptss();
            receiptss.Show();
            Form parentForm = this.ParentForm;
            parentForm.Hide();
        }
    }
}
