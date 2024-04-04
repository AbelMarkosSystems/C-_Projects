using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankSystem
{
    public partial class AccountProfile : UserControl
    {
        public AccountProfile()
        {
            InitializeComponent();
        }
        bool sideBarExpand;
        private void sidebarbtn_Click(object sender, EventArgs e)
        {

        }

        private void sidebarbtn_Click_1(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void SideBarEcpand(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    // sideBar.Width -= sideBar.MaximumSize.Width;
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    //  sideBar.Width += sideBar.MaximumSize.Width;
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }
        SqlConnection Conns;
        private void AccountProfile_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DashbourdTransfer.Controls.Clear();
            string accountNumber = Microsoft.VisualBasic.Interaction.InputBox("Enter Account Number", "Account Number", "");
            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter Password", "Password", "");

            string query = $"SELECT Balance FROM Accounts WHERE Acc_Number = '{accountNumber}' AND Password = '{password}'";

            try
            {
                EnsureConnectionOpen(Conns); // Ensure the connection is open

                using (SqlCommand command = new SqlCommand(query, Conns))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal balance = (decimal)result;
                        MessageBox.Show($"Balance of account {accountNumber}: {balance}");
                    }
                    else
                    {
                        MessageBox.Show($"Invalid account number or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Conns.State == ConnectionState.Open)
                {
                    Conns.Close();
                }
            }
        }
        private void EnsureConnectionOpen(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            transferUserAmount transferUserAmount = new transferUserAmount();
            DashbourdTransfer.Controls.Add(transferUserAmount);

        }
    }
    
}
