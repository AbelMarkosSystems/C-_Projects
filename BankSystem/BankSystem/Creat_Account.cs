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

namespace BankSystem
{
    public partial class Creat_Account : Form
    {
        public Creat_Account()
        {
            InitializeComponent();
        }

        SqlConnection Conns;

        private void Creat_Account_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
        }
        private void txtblname_Click(object sender, EventArgs e)
        {
            if (txtblname.Text == "last name")
            {
                txtblname.Text = string.Empty;
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string fn = txtbfname.Text;
            if (fn.Equals("first name"))
            {
                txtbfname.Text = string.Empty;
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtbfname.Text = string.Empty;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string fn = txtbfname.Text;
            if (fn.Equals("first name"))
            {
                txtbfname.Text = string.Empty;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string fn = txtbfname.Text;
            if (fn.Equals("first name"))
            {
                txtbfname.Text = string.Empty;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtblname.Text == "last name")
            {
                txtblname.Text = string.Empty;
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txtbdate.Text = DateTime.Now.ToString();
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
        private void txtbfname_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            BankSystems form12 = new BankSystems();
            form12.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbfname.Text = string.Empty;
            txtblname.Text = string.Empty;
            txtbgender.Text = string.Empty;
            txtbage.Text = string.Empty;
            txtbdate.Text = string.Empty;
            txtbbalance.Text = string.Empty;
            txtbGamil.Text = string.Empty;
            imgBox.Image = null;
            txtbfname.Focus();
        }

        private void btncreat_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream sterem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(sterem);
                images = br.ReadBytes((int)sterem.Length);

                string a = txtbbalance.Text;
                double result;
                Double.TryParse(a, out result);
                SqlCommand cmd = new SqlCommand("INSERT INTO Accounts VALUES('" + txtbfname.Text + "', '" + txtblname.Text + "', '" + txtbgender.Text + "'," + txtbage.Text +" , '" + txtbdate.Text + "', " + result + ", '" + txtbGamil.Text + "','"+ null +"',@images)", Conns);
                Conns.Open();
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account is Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conns.Close(); // Close the connection in the finally block
            }
        }
        string imgLocation = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                imgBox.ImageLocation = imgLocation;
            }
        }
    }

}
