using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankSystem
{
    public partial class transferUserAmount : UserControl
    {
        public transferUserAmount()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void transferUserAmount_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senderAccountNumber = txtbSender.Text;
            string pass = ShowPasswordInputDialog("Enter Sender Password", "Sender Password");
            string receiverAccountNumber = txtbreceiver.Text;
            decimal transferAmount = Convert.ToDecimal(txtbamount.Text);

            // Verify sender's account number and password
            if (!VerifyAccount(senderAccountNumber, pass))
            {
                MessageBox.Show("Invalid sender account number or password.");
                return;
            }

            // Check sender's balance
            decimal senderBalance = GetAccountBalance(senderAccountNumber);
            if (senderBalance < transferAmount)
            {
                MessageBox.Show("Insufficient balance in the sender's account.");
                return;
            }

            // Perform the transfer
            if (PerformTransfer(senderAccountNumber, receiverAccountNumber, transferAmount))
            {
                MessageBox.Show($"Amount {transferAmount} transferred successfully from account {senderAccountNumber} to account {receiverAccountNumber}.");
            }
            else
            {
                MessageBox.Show("Failed to transfer the amount.");
            }
        }

        private bool VerifyAccount(string accountNumber, string password)
        {
            string query = $"SELECT COUNT(*) FROM Accounts WHERE Acc_Number = '{accountNumber}' AND Password = '{password}'";

            try
            {
                using (SqlCommand command = new SqlCommand(query, Conns))
                {
                    Conns.Open();
                    int count = (int)command.ExecuteScalar();
                    Conns.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private decimal GetAccountBalance(string accountNumber)
        {
            string query = $"SELECT Balance FROM Accounts WHERE Acc_Number = '{accountNumber}'";

            try
            {
                using (SqlCommand command = new SqlCommand(query, Conns))
                {
                    Conns.Open();
                    object result = command.ExecuteScalar();
                    Conns.Close();

                    return result != null && result != DBNull.Value ? (decimal)result : 0;
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred: " + ex.Message);
                return 0;
            }
        }

        private bool PerformTransfer(string senderAccountNumber, string receiverAccountNumber, decimal amount)
        {
            SqlTransaction transaction = null;

            try
            {
                Conns.Open();
                transaction = Conns.BeginTransaction();

                // Deduct amount from sender's account
                string senderUpdateQuery = $"UPDATE Accounts SET Balance = Balance - {amount} WHERE Acc_Number = '{senderAccountNumber}'";
                using (SqlCommand senderCommand = new SqlCommand(senderUpdateQuery, Conns, transaction))
                {
                    int senderAffectedRows = senderCommand.ExecuteNonQuery();
                    if (senderAffectedRows == 0)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }

                // Add amount to receiver's account
                string receiverUpdateQuery = $"UPDATE Accounts SET Balance = Balance + {amount} WHERE Acc_Number = '{receiverAccountNumber}'";
                using (SqlCommand receiverCommand = new SqlCommand(receiverUpdateQuery, Conns, transaction))
                {
                    int receiverAffectedRows = receiverCommand.ExecuteNonQuery();
                    if (receiverAffectedRows == 0)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred: " + ex.Message);
                transaction?.Rollback();
                return false;
            }
            finally
            {
                Conns.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbamount.Clear();
            txtbreceiver.Clear();
            txtbSender.Clear();
            txtbSender.Focus();

        }
        private string ShowPasswordInputDialog(string prompt, string title)
        {
            Form passwordForm = new Form();
            passwordForm.Text = title;
            Label promptLabel = new Label() { Left = 20, Top = 20, Text = prompt };
            TextBox passwordBox = new TextBox() { Left = 20, Top = 50, UseSystemPasswordChar = true, Width = 200 };
            Button confirmButton = new Button() { Text = "OK", Left = 20, Top = 80, Width = 80 };
            Button cancelButton = new Button() { Text = "Cancel", Left = 120, Top = 80, Width = 80 };

            confirmButton.Click += (sender, e) => { passwordForm.DialogResult = DialogResult.OK; };
            cancelButton.Click += (sender, e) => { passwordForm.DialogResult = DialogResult.Cancel; };
            passwordForm.FormClosing += (sender, e) =>
            {
                if (passwordForm.DialogResult != DialogResult.OK)
                    passwordBox.Text = ""; // Clear the password if canceled
            };

            passwordForm.Controls.Add(promptLabel);
            passwordForm.Controls.Add(passwordBox);
            passwordForm.Controls.Add(confirmButton);
            passwordForm.Controls.Add(cancelButton);

            DialogResult dialogResult = passwordForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return passwordBox.Text;
            else
                return ""; // Return empty string if canceled
        }

    }
}
