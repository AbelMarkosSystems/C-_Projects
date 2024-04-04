using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BankSystem;

namespace BankSystems
{
    public partial class Receiptss : Form
    {
        public Receiptss()
        {
            InitializeComponent();
        }
        private void Receipt_Load(object sender, EventArgs e)
        {

        }
        int vCode = 1000;
       
        SqlConnection Conns;
        private void Receipt_Load_1(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            string to = txtbgemaill.Text;
            string from = "markosganamo@gmail.com"; // Replace with the sender's email address
            string mail = vCode.ToString();
            string pass = "oikapremlznrsuhx"; // Replace with the sender's email password
            try
            {
                //o i k a p r e m l z n r s u h x
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Subject = "Your Bank Account Verification Code From Bank Administration";
                message.Body = "Dear user,\n\n"
                + "Thank you for using our banking services. Your verification code is: " + mail + "\n\n"
                + "Please enter this code to complete the verification process.\n\n"
                + "Best regards,\n"
                + "Bank Administration";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);



                smtp.Send(message);
                MessageBox.Show("Verification Code Is Sent Successfully! Please check your email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbCode.Enabled = true;
                btconfirm.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }

        private void btconfirm_Click(object sender, EventArgs e)
        {
            if (txtbCode.Text == vCode.ToString())
            {
                try
                {
                    Conns.Open(); // Ensure the connection is open
                    string password = txtbpass.Text;
                    string Gmail = txtbgemaill.Text;
                    string acountnum = txtbacc.Text;
                    string updateQuery = $"UPDATE Accounts SET Password = '{password}' WHERE Acc_Number = '{acountnum}' AND Gmail = '{Gmail}'";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, Conns))
                    {
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your Account password forgoted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    MessageBox.Show("An error occurred while updating the password: " + ex.Message);
                }
                finally
                {
                    if (Conns.State == ConnectionState.Open)
                    {
                        Conns.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Verification Code!!");
            }
        }

        private void btnbak_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void Timer_ticks(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }
    }
}
