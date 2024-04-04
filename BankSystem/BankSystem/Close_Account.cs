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
    public partial class CloseAccount : Form
    {
        public CloseAccount()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void CloseAccount_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void sidebarbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void SideBarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Paint(object sender, PaintEventArgs e)
        {

        }
         private void button1_Click(object sender, EventArgs e)
           {
            string accountNumber = txtbAccountNumber.Text;

            try
            {
                Conns.Open();

                SqlDataReader reader = RetrieveAccountFromDatabase(Conns, accountNumber);
                if (reader.HasRows)
                {
                    InsertIntoClosedAccountsTable(reader);

                    reader.Close();
                    DeleteAccountFromAccountsTable(Conns, accountNumber);

                    MessageBox.Show("Account closed successfully.");
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Conns.Close();
            }
        }

        private void InsertIntoClosedAccountsTable(SqlDataReader reader)
        {
            if (reader.Read()) // Check if there is data to read
            {
                // Get the column values from the reader
                string accountNumber = reader["Acc_Number"].ToString();
                string firstName = reader["FName"].ToString();
                string lastName = reader["LName"].ToString();
                string gender = reader["Gender"].ToString();
                int age = (int)reader["Age"];
                DateTime date = (DateTime)reader["Date"];
                decimal balance = (decimal)reader["Balance"];
                string email = reader["Gmail"].ToString();
                string password = reader["Password"].ToString();

                // Get the image data from the reader
                byte[] imageData = (byte[])reader["ImageData"];

                // Close the reader before executing the insert query
                reader.Close();

                // Insert the data into the Close_Accounts table
                using (SqlCommand insertCommand = Conns.CreateCommand())
                {
                    insertCommand.CommandText = "INSERT INTO Closed_Accounts (Acc_Number, FName, LName, Gender, Age, Date, Balance, Gmail, Password, ImageData) " +
                                                "VALUES (@AccountNumber, @FirstName, @LastName, @Gender, @Age, @Date, @Balance, @Email, @Password, @ImageData)";
                    insertCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertCommand.Parameters.AddWithValue("@Gender", gender);
                    insertCommand.Parameters.AddWithValue("@Age", age);
                    insertCommand.Parameters.AddWithValue("@Date", date);
                    insertCommand.Parameters.AddWithValue("@Balance", balance);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@ImageData", imageData);

                    // Execute the insert query
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private SqlDataReader RetrieveAccountFromDatabase(SqlConnection connection, string accountNumber)
        {
            // Retrieve all columns from the Accounts table based on the account number
            string query = "SELECT Acc_Number, FName, LName, Gender, Age, Date, Balance, Gmail, Password, ImageData " +
                           "FROM Accounts WHERE Acc_Number = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", accountNumber);

            // Execute the query and retrieve the data
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        private void DeleteAccountFromAccountsTable(SqlConnection connection, string accountNumber)
        {
            // Delete the account from the Accounts table
            string query = "DELETE FROM Accounts WHERE Acc_Number = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", accountNumber);

            // Execute the delete query
            command.ExecuteNonQuery();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            BankSystems bankSystems = new BankSystems();
            bankSystems.Show();
            this.Close();
        }
    }
}
