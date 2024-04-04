using BankSystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class BankSystems : Form
    {
        
        public BankSystems()
        {
            InitializeComponent();
           
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            Creat_Account form = new Creat_Account();
            form.Show();
            this.Hide();
        }

        private void BankSystems_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndeposit_Click(object sender, EventArgs e)
        {  
            Deposit_Funds dform = new Deposit_Funds();
            dform.Show();
            this.Hide();
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            WithDraw_Amount withDraw_Amount = new WithDraw_Amount();    
            withDraw_Amount.Show();
            this.Hide();
        }

      

        private void btncheack_Click(object sender, EventArgs e)
        {
            CheakAccountsForm frm = new CheakAccountsForm();
            frm.Show();
            this.Hide();
        }
        private void addusercontrols(UserControl userControl)
        {
            panelhome.Controls.Clear();
            panelhome.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            US_UpdateAccounts up=new US_UpdateAccounts();
            addusercontrols(up);
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
    
                Transfer_Amount fb = new Transfer_Amount();
                fb.Show();
                this.Hide();
                // Get the account details from the UI
               
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            CloseAccount usersMenu = new CloseAccount();
            usersMenu.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm form12 = new LoginForm();
            form12.Show();
            this.Hide();
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

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
