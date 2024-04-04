using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystems
{
    public partial class WithDraw_Amount : Form
    {
        public WithDraw_Amount()
        {
            InitializeComponent();
        }

        SqlConnection Conns;
        private void Deposit_Amount_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal withdrawalAmount;
            if (!decimal.TryParse(txtbBalance.Text, out withdrawalAmount))
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid number.");
                return;
            }

            // Establish a database connection
          
            
                try
                {
                Conns.Open();

                    // Retrieve the current balance from the database
                    decimal currentBalance = GetBalanceFromDatabase(Conns);

                    // Check if the withdrawal amount is valid
                    if (withdrawalAmount <= 0)
                    {
                        MessageBox.Show("Withdrawal amount must be greater than zero.");
                        return;
                    }

                    if (withdrawalAmount > currentBalance)
                    {
                        MessageBox.Show("Insufficient balance. Cannot withdraw more than the current balance.");
                        return;
                    }
                    decimal updatedBalance = currentBalance - withdrawalAmount;
                    UpdateDatabaseBalance(Conns, updatedBalance);
                    MessageBox.Show($"Withdrawal successful. Your new balance is: {updatedBalance.ToString("C")}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                
                }
            finally { Conns.Close(); }
            
        }

   
        private decimal GetBalanceFromDatabase(SqlConnection connection)
        {
            string acountNUM = txtbAccountNumber.Text;
            // Retrieve the current balance from the database
            string query = "SELECT Balance FROM Accounts WHERE Acc_Number = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", acountNUM);

            // Execute the query and retrieve the balance
            decimal balance = (decimal)command.ExecuteScalar();

            return balance;
        }

        private void UpdateDatabaseBalance(SqlConnection connection, decimal newBalance)
        {
            string acountNUM = txtbAccountNumber.Text;
            // Update the database with the new balance
            string query = "UPDATE Accounts SET Balance = @NewBalance WHERE Acc_Number = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewBalance", newBalance);
            command.Parameters.AddWithValue("@AccountNumber", acountNUM);

            // Execute the update query
            command.ExecuteNonQuery();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BankSystem.BankSystems bankSystems = new BankSystem.BankSystems();
            bankSystems.Show();
            this.Close();

        }

        private void btnVeaw_Click(object sender, EventArgs e)
        {

            string accountNumber = txtbAccountNumber.Text;

                try
                {
                Conns.Open();              
                    string query = "SELECT ImageData FROM Accounts WHERE Acc_Number = @AccountNumber";            
                    using (SqlCommand command = new SqlCommand(query, Conns))
                    {                      
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);                      
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {                            
                                byte[] imageData = (byte[])reader["ImageData"];

                                // Create a MemoryStream from the image data
                                using (MemoryStream stream = new MemoryStream(imageData))
                                {                                  
                                    imgBox.Image = Image.FromStream(stream);
                                }
                            }
                            else
                            {
                                
                                MessageBox.Show("No image found for account number: " + accountNumber);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            finally { Conns.Close(); }
            
        }
    }
}
