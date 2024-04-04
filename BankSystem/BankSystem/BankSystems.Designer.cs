namespace BankSystem
{
    partial class BankSystems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankSystems));
            this.btncreate = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btncheack = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btntransfer = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelhome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Image = ((System.Drawing.Image)(resources.GetObject("btncreate.Image")));
            this.btncreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreate.Location = new System.Drawing.Point(-4, 4);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(238, 57);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Create Account";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Blue;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Location = new System.Drawing.Point(455, 13);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(100, 35);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Plum;
            this.btnexit.Location = new System.Drawing.Point(574, 13);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 35);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndeposit
            // 
            this.btndeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposit.Image = ((System.Drawing.Image)(resources.GetObject("btndeposit.Image")));
            this.btndeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeposit.Location = new System.Drawing.Point(1, 69);
            this.btndeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(236, 62);
            this.btndeposit.TabIndex = 5;
            this.btndeposit.Text = "Deposit Amount";
            this.btndeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnwithdraw.Image")));
            this.btnwithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnwithdraw.Location = new System.Drawing.Point(1, 140);
            this.btnwithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(236, 67);
            this.btnwithdraw.TabIndex = 6;
            this.btnwithdraw.Text = "Withdraw Amount";
            this.btnwithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btncheack
            // 
            this.btncheack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheack.Image = ((System.Drawing.Image)(resources.GetObject("btncheack.Image")));
            this.btncheack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheack.Location = new System.Drawing.Point(1, 353);
            this.btncheack.Margin = new System.Windows.Forms.Padding(4);
            this.btncheack.Name = "btncheack";
            this.btncheack.Size = new System.Drawing.Size(235, 61);
            this.btncheack.TabIndex = 7;
            this.btncheack.Text = "Cheack Acccount";
            this.btncheack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncheack.UseVisualStyleBackColor = true;
            this.btncheack.Click += new System.EventHandler(this.btncheack_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(1, 286);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(236, 59);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update Account";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btntransfer
            // 
            this.btntransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransfer.Image = ((System.Drawing.Image)(resources.GetObject("btntransfer.Image")));
            this.btntransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransfer.Location = new System.Drawing.Point(1, 215);
            this.btntransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(236, 63);
            this.btntransfer.TabIndex = 9;
            this.btntransfer.Text = "Transfer Amount";
            this.btntransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntransfer.UseVisualStyleBackColor = true;
            this.btntransfer.Click += new System.EventHandler(this.btntransfer_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(0, 422);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(235, 63);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close Account";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "HOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Controls.Add(this.btndeposit);
            this.panel1.Controls.Add(this.btnwithdraw);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btncheack);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btntransfer);
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 485);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 64);
            this.panel2.TabIndex = 13;
            // 
            // panelhome
            // 
            this.panelhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelhome.BackgroundImage")));
            this.panelhome.Location = new System.Drawing.Point(242, 64);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(511, 481);
            this.panelhome.TabIndex = 14;
            this.panelhome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelhome_Paint);
            // 
            // BankSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(753, 544);
            this.Controls.Add(this.panelhome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankSystems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankSystems";
            this.Load += new System.EventHandler(this.BankSystems_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btncheack;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelhome;
    }
}