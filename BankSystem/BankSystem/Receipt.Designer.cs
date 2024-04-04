namespace BankSystems
{
    partial class Receiptss
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbacc = new System.Windows.Forms.TextBox();
            this.txtbCode = new System.Windows.Forms.TextBox();
            this.txtbconfim = new System.Windows.Forms.TextBox();
            this.txtbpass = new System.Windows.Forms.TextBox();
            this.txtbgemaill = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btconfirm = new System.Windows.Forms.Button();
            this.btnbak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_ticks);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(91, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(171, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(106, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "New Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(75, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Confirm Passwoord";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(249, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Verification Code";
            // 
            // txtbacc
            // 
            this.txtbacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbacc.Location = new System.Drawing.Point(227, 69);
            this.txtbacc.Name = "txtbacc";
            this.txtbacc.Size = new System.Drawing.Size(147, 26);
            this.txtbacc.TabIndex = 5;
            // 
            // txtbCode
            // 
            this.txtbCode.Enabled = false;
            this.txtbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbCode.Location = new System.Drawing.Point(252, 249);
            this.txtbCode.Name = "txtbCode";
            this.txtbCode.Size = new System.Drawing.Size(107, 26);
            this.txtbCode.TabIndex = 7;
            // 
            // txtbconfim
            // 
            this.txtbconfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbconfim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbconfim.Location = new System.Drawing.Point(227, 177);
            this.txtbconfim.Name = "txtbconfim";
            this.txtbconfim.Size = new System.Drawing.Size(147, 26);
            this.txtbconfim.TabIndex = 8;
            this.txtbconfim.UseSystemPasswordChar = true;
            // 
            // txtbpass
            // 
            this.txtbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbpass.Location = new System.Drawing.Point(227, 142);
            this.txtbpass.Name = "txtbpass";
            this.txtbpass.Size = new System.Drawing.Size(147, 26);
            this.txtbpass.TabIndex = 9;
            this.txtbpass.UseSystemPasswordChar = true;
            // 
            // txtbgemaill
            // 
            this.txtbgemaill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbgemaill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbgemaill.Location = new System.Drawing.Point(227, 107);
            this.txtbgemaill.Name = "txtbgemaill";
            this.txtbgemaill.Size = new System.Drawing.Size(147, 26);
            this.txtbgemaill.TabIndex = 10;
            // 
            // btSend
            // 
            this.btSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSend.Location = new System.Drawing.Point(146, 252);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 11;
            this.btSend.Text = "Send Code";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btconfirm
            // 
            this.btconfirm.Enabled = false;
            this.btconfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btconfirm.Location = new System.Drawing.Point(383, 252);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.Size = new System.Drawing.Size(75, 23);
            this.btconfirm.TabIndex = 12;
            this.btconfirm.Text = "Confirm";
            this.btconfirm.UseVisualStyleBackColor = true;
            this.btconfirm.Click += new System.EventHandler(this.btconfirm_Click);
            // 
            // btnbak
            // 
            this.btnbak.Location = new System.Drawing.Point(79, 341);
            this.btnbak.Name = "btnbak";
            this.btnbak.Size = new System.Drawing.Size(75, 23);
            this.btnbak.TabIndex = 13;
            this.btnbak.Text = "Back";
            this.btnbak.UseVisualStyleBackColor = true;
            this.btnbak.Click += new System.EventHandler(this.btnbak_Click);
            // 
            // Receiptss
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 396);
            this.Controls.Add(this.btnbak);
            this.Controls.Add(this.btconfirm);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtbgemaill);
            this.Controls.Add(this.txtbpass);
            this.Controls.Add(this.txtbconfim);
            this.Controls.Add(this.txtbCode);
            this.Controls.Add(this.txtbacc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Receiptss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Receipt_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfrim;
        private System.Windows.Forms.TextBox txtbConfrim;
        private System.Windows.Forms.TextBox TxtbConfifrmPass;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbGmail;
        private System.Windows.Forms.TextBox txtbAccountNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer Timer_track;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbacc;
        private System.Windows.Forms.TextBox txtbCode;
        private System.Windows.Forms.TextBox txtbconfim;
        private System.Windows.Forms.TextBox txtbpass;
        private System.Windows.Forms.TextBox txtbgemaill;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btconfirm;
        private System.Windows.Forms.Button btnbak;
    }
}