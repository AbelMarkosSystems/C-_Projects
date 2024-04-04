using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BankSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4LEQQRE;Initial Catalog=Bank_Management_System;Integrated Security=True;Trust Server Certificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
        SqlConnection Conns;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["smsConn"];
            string strcon = conn.ConnectionString;
            Conns = new SqlConnection(strcon);
            Conns.Open();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtbuser.Text;
            password = txbpassword.Text;

           
            
            try
            {
                String cmd = ("select * from Login where username = '" + txtbuser.Text + "' and password='" + txbpassword.Text + "' ");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, Conns);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                    if (dt.Rows.Count > 0)
                    {
                        username = txtbuser.Text;
                        password = txbpassword.Text;

                        BankSystems form12 = new BankSystems();
                        form12.Show();
                        this.Hide();

                   }
                
               /* else if(cmbusertype.Text == "User")
                {
                    UsersMenu usersMenu = new UsersMenu();
                    usersMenu.Show();
                    this.Hide();

                }*/
                else {
                    MessageBox.Show("incorrect user name or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbuser.Clear();
                    txbpassword.Clear();

                    txtbuser.Focus();
                }
            }
            catch {
                MessageBox.Show("Error");
            }
            finally {
                Conns.Close();
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbuser.Clear();
            txbpassword.Clear();
            txtbuser.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res=MessageBox.Show("Do You Want To Exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (res == DialogResult.Yes) {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
