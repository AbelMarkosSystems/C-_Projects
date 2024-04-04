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
    public partial class US_UpdateAccounts : UserControl
    {
        public US_UpdateAccounts()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void US_UpdateAccounts_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            string accNumber = txtbAccountNumber.Text;
            string firstName = txtbLName.Text;
            string lastName = txtbFName.Text;
            
           
                try
                {
                Conns.Open();
                    UpdateDatabaseFields(Conns, accNumber, firstName, lastName);

                    MessageBox.Show("Database updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            finally { Conns.Close(); }
            
        }

        private void UpdateDatabaseFields(SqlConnection connection, string accNumber, string firstName, string lastName)
        {
            string query = "UPDATE Accounts SET FName = @FirstName, LName = @LastName WHERE Acc_Number = @AccNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbAccountNumber.Clear();
            txtbLName.Clear();
            txtbFName.Clear();
        }
    }
}
