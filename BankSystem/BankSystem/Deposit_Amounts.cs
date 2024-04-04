using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Deposit_Funds : Form
    {
        public Deposit_Funds()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankSystems form12 = new BankSystems();
            form12.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            string accountNumber = txtbAccountNumber.Text;
            decimal depositAmount = decimal.Parse(txtbBalance.Text);

            // Check if the account number exists in the database
            bool accountExists = CheckAccountExists(accountNumber);

            if (accountExists)
            {
                // Retrieve the account balance from the database
                decimal oldBalance = GetAccountBalance(accountNumber);

                // Update the account balance with the deposit amount
                decimal newBalance = oldBalance + depositAmount;

                // Update the account balance in the database
                UpdateAccountBalance(accountNumber, newBalance);

                // Display a success message to the user
                MessageBox.Show($"Deposit of {depositAmount:C} successful. New balance: {newBalance:C}");
            }
            else
            {
                // Display an error message if the account number doesn't exist
                MessageBox.Show("Invalid account number. Please try again.");
            }
        }
        private bool CheckAccountExists(string accountNumber)
        {
            bool accountExists = false;

            // TODO: Replace with your database connection string
            

           
            {
                Conns.Open();

                // TODO: Replace with your database query to check account existence
                string query = "SELECT COUNT(*) FROM Accounts WHERE Acc_Number = @AccountNumber";
                SqlCommand command = new SqlCommand(query, Conns);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    accountExists = true;
                }

                Conns.Close();
            }

            return accountExists;
        }

        private decimal GetAccountBalance(string accountNumber)
        {
            decimal balance = 0;

            // TODO: Replace with your database connection string
            {
                Conns.Open();

                // TODO: Replace with your database query to retrieve account balance
                string query = "SELECT Balance FROM Accounts WHERE Acc_Number = @AccountNumber";
                SqlCommand command = new SqlCommand(query, Conns);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    balance = Convert.ToDecimal(reader["Balance"]);
                }
                reader.Close();
                Conns.Close();
            }

            return balance;
        }

        private void UpdateAccountBalance(string accountNumber, decimal newBalance)
        {
            // TODO: Replace with your database connection string
            {
                Conns.Open();

                // TODO: Replace with your database query to update account balance
                string query = "UPDATE Accounts SET Balance = @NewBalance WHERE Acc_Number = @AccountNumber";
                SqlCommand command = new SqlCommand(query, Conns);
                command.Parameters.AddWithValue("@NewBalance", newBalance);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                command.ExecuteNonQuery();

                Conns.Close();
            }
        }
    }

 }

