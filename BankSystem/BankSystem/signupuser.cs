using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BankSystem
{
    public partial class signupuser : UserControl
    {
        public signupuser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void EnsureConnectionOpen(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        SqlConnection Conns;
        int vCode=1000;
        private void signupuser_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer_track.Stop();
            string to = txtbGmail.Text;
            string from = "markosganamo@gmail.com"; // Replace with the sender's email address
            string mail = vCode.ToString();
            string pass = "oikapremlznrsuhx"; // Replace with the sender's email password

            // Check if the password is null or empty in the database
            EnsureConnectionOpen(Conns);
                string query = "SELECT Password FROM Accounts WHERE Gmail = @Email";
                using (SqlCommand command = new SqlCommand(query, Conns))
                {
                    command.Parameters.AddWithValue("@Email", txtbGmail.Text);
                    object result = command.ExecuteScalar();
                    if (result == null || result == DBNull.Value || string.IsNullOrEmpty(result.ToString()))
                    {
                        // Password is null or empty in the database, send the code
                        try
                        {
                            MailMessage message = new MailMessage();
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Subject = "Your Bank Account Verification Code From Information Systems Bank Administration";
                            message.Body = "Dear user,\n\n"
                                + "Thank you for using our banking services. Your verification code is: " + mail + "\n\n"
                                + "Please enter this code to complete the verification process.\n\n"
                                + "Best regards,\n"
                                + "Information Systems Bank Administration";

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);

                            smtp.Send(message);
                            MessageBox.Show("Verification Code Is Sent Successfully! Please check your email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtbConfrim.Enabled = true;
                            BtnConfrim.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to send email. Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account already verified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
           
        }

        private void Timer_track_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }
       
        private void BtnConfrim_Click(object sender, EventArgs e)
        {
            if (txtbPassword.Text == TxtbConfifrmPass.Text) // Check if password matches confirm password
            {
                if (txtbConfrim.Text == vCode.ToString())
                {
                    try
                    {
                        EnsureConnectionOpen(Conns); // Ensure the connection is open
                        string password = txtbPassword.Text;
                        string Gmail = txtbGmail.Text;
                        string acountnum = txtbAccountNumber.Text;
                        string updateQuery = $"UPDATE Accounts SET Password = '{password}' WHERE Acc_Number = '{acountnum}' AND Gmail = '{Gmail}'";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, Conns))
                        {
                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your Account Verified successfully.");
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
            else
            {
                MessageBox.Show("Password and Confirm Password do not match.");
            }
        }
    }
}
