namespace BankSystems
{
    partial class Transfer_Amount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer_Amount));
            this.txtbsend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntransfer = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtbsender = new System.Windows.Forms.TextBox();
            this.txtbreciever = new System.Windows.Forms.TextBox();
            this.txtbtransfer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtbsend
            // 
            this.txtbsend.AutoSize = true;
            this.txtbsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbsend.Location = new System.Drawing.Point(12, 95);
            this.txtbsend.Name = "txtbsend";
            this.txtbsend.Size = new System.Drawing.Size(182, 16);
            this.txtbsend.TabIndex = 0;
            this.txtbsend.Text = "Sender Account Number :";
            this.txtbsend.Click += new System.EventHandler(this.txtbsender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reciever Account Number :";
            // 
            // btntransfer
            // 
            this.btntransfer.BackColor = System.Drawing.Color.Lime;
            this.btntransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransfer.Location = new System.Drawing.Point(388, 224);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(102, 43);
            this.btntransfer.TabIndex = 2;
            this.btntransfer.Text = "Transfer Amount";
            this.btntransfer.UseVisualStyleBackColor = false;
            this.btntransfer.Click += new System.EventHandler(this.btntransfer_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(202, 224);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 43);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Clear";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(305, 356);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 32);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(179, 356);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(84, 32);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(24, 356);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 32);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtbsender
            // 
            this.txtbsender.Location = new System.Drawing.Point(211, 95);
            this.txtbsender.Name = "txtbsender";
            this.txtbsender.Size = new System.Drawing.Size(279, 20);
            this.txtbsender.TabIndex = 7;
            this.txtbsender.TextChanged += new System.EventHandler(this.txtbsender_TextChanged);
            // 
            // txtbreciever
            // 
            this.txtbreciever.Location = new System.Drawing.Point(211, 135);
            this.txtbreciever.Name = "txtbreciever";
            this.txtbreciever.Size = new System.Drawing.Size(279, 20);
            this.txtbreciever.TabIndex = 8;
            // 
            // txtbtransfer
            // 
            this.txtbtransfer.Location = new System.Drawing.Point(211, 177);
            this.txtbtransfer.Name = "txtbtransfer";
            this.txtbtransfer.Size = new System.Drawing.Size(279, 20);
            this.txtbtransfer.TabIndex = 9;
            this.txtbtransfer.TextChanged += new System.EventHandler(this.txtbtransfer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transfer Amount :";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(520, 56);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(329, 211);
            this.txtresult.TabIndex = 11;
            this.txtresult.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(720, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(504, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Transaction Receipt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Transfer Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Transfer_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(876, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbtransfer);
            this.Controls.Add(this.txtbreciever);
            this.Controls.Add(this.txtbsender);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btntransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbsend);
            this.Name = "Transfer_Amount";
            this.Text = "Transfer_Amount";
            this.Load += new System.EventHandler(this.Transfer_Amount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtbsend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtbsender;
        private System.Windows.Forms.TextBox txtbreciever;
        private System.Windows.Forms.TextBox txtbtransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}