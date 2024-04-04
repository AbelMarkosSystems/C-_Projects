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
    public partial class CheakAccountsForm : Form
    {
        public CheakAccountsForm()
        {
            InitializeComponent();
        }
        SqlConnection Conns;
        private void CheakAccountsForm_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
            Conns.Open();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from Accounts",Conns);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CheackAccountsGridVeaw.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from Accounts where Acc_Number=@Acc_Number", Conns);
            com.Parameters.AddWithValue("Acc_Number", textAcc_Number.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CheackAccountsGridVeaw.DataSource = dt;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BankSystems form12 = new BankSystems();
            form12.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }
    }
}
