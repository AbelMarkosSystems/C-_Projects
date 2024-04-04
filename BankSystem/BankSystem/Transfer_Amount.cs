using BankSystem;
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

namespace BankSystems
{
    public partial class Transfer_Amount : Form
    {
        public Transfer_Amount()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void Transfer_Amount_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
            Conns.Open();
        }
       string senderAccountNumbe;
      
        private void btntransfer_Click(object sender, EventArgs e)
        {
            try
            {
               senderAccountNumbe = txtbsender.Text.ToString();
                string senderAccountNumber = txtbsender.Text.ToString();
                string receiverAccountNumber = txtbreciever.Text.ToString();
                decimal transferAmount = decimal.Parse(txtbtransfer.Text);
                // Retrieve sender account details from the database
                SqlCommand senderCmd = new SqlCommand("SELECT Balance FROM Accounts WHERE Acc_Number = @SenderAccountNumber", Conns);
                
                senderCmd.Parameters.AddWithValue("@SenderAccountNumber", senderAccountNumber);

                object senderBalanceObj = senderCmd.ExecuteScalar();
                if (senderBalanceObj != null && decimal.TryParse(senderBalanceObj.ToString(), out decimal senderBalance))
                {
                    // Check if the sender has sufficient balance
                    if (senderBalance < transferAmount)
                    {
                        MessageBox.Show("Insufficient balance. Transfer cannot be completed.");
                     //   Conns.Close();
                        return;
                    }

                    // Retrieve receiver account details from the database
                    SqlCommand receiverCmd = new SqlCommand("SELECT Balance FROM Accounts WHERE Acc_Number = @ReceiverAccountNumber", Conns);
                    receiverCmd.Parameters.AddWithValue("@ReceiverAccountNumber", receiverAccountNumber);
                    object receiverBalanceObj = receiverCmd.ExecuteScalar();
                    if (receiverBalanceObj != null && decimal.TryParse(receiverBalanceObj.ToString(), out decimal receiverBalance))
                    {
                        // Update sender account balance
                        decimal updatedSenderBalance = senderBalance - transferAmount;
                        SqlCommand updateSenderCmd = new SqlCommand("UPDATE Accounts SET Balance = @UpdatedSenderBalance WHERE Acc_Number = @SenderAccountNumber", Conns);
                        updateSenderCmd.Parameters.AddWithValue("@UpdatedSenderBalance", updatedSenderBalance);
                        updateSenderCmd.Parameters.AddWithValue("@SenderAccountNumber", senderAccountNumber);
                        updateSenderCmd.ExecuteNonQuery();

                        // Update receiver account balance
                        decimal updatedReceiverBalance = receiverBalance + transferAmount;
                        SqlCommand updateReceiverCmd = new SqlCommand("UPDATE Accounts SET Balance = @UpdatedReceiverBalance WHERE Acc_Number = @ReceiverAccountNumber", Conns);
                        updateReceiverCmd.Parameters.AddWithValue("@UpdatedReceiverBalance", updatedReceiverBalance);
                        updateReceiverCmd.Parameters.AddWithValue("@ReceiverAccountNumber", receiverAccountNumber);
                        updateReceiverCmd.ExecuteNonQuery();
                       
                        txtresult.Clear();
                        txtresult.Text += "**********************************\n";
                        txtresult.Text += "***  Transactions Receipt      ***\n";
                        txtresult.Text += "**********************************\n";
                        txtresult.Text += "Date :" + DateTime.Now + "\n\n";
                        txtresult.Text += "Sender Account Number :" + txtbsender.Text + "\n\n";
                        txtresult.Text += "Receiver Account Number :" + txtbreciever.Text + "\n\n";
                        txtresult.Text += "Amount :" + txtbtransfer.Text + "\n\n";
                        txtresult.Text += "\n\n                 Signature\n\n";

                        Conns.Close();
                        MessageBox.Show("Transfer completed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid receiver account number.");
                        Conns.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid sender account number.");
                    Conns.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtbtransfer_TextChanged(object sender, EventArgs e)
        {

        }
        public  String pay()
        {
            string abi = senderAccountNumbe;
            return abi;
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

        private void btncancel_Click(object sender, EventArgs e)
        {

            txtbsender.Clear();
            txtbreciever.Clear();
            txtbsender.Focus();
        }

        private void txtbsender_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            BankSystem.BankSystems form12 = new BankSystem.BankSystems();
            form12.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }

        public void txtbsender_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtresult.Text,new Font("Microsoft Sans Serif",18,FontStyle.Bold), Brushes.Black,new Point(10,10));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
