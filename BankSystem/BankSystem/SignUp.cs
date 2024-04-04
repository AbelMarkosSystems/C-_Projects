using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class SignUp : Form
    {
        public Panel Dashbourdd { get; } 

        public SignUp()
        {
            InitializeComponent();
            Dashbourdd = Dashbourd;
        }
        public string AccountNumber { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Dashbourd.Controls.Clear();
            LoginUser up = new LoginUser();
            Dashbourd.Controls.Add(up);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashbourd.Controls.Clear();
            signupuser up = new signupuser();
            Dashbourd.Controls.Add(up);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void signupuser1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Dashbourd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
        }
    }
}
