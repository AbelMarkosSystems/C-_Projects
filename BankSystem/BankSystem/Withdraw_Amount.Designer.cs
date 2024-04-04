namespace BankSystems
{
    partial class WithDraw_Amount
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtbAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbBalance = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.btnVeaw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Nunber :";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransfer.Location = new System.Drawing.Point(250, 247);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 31);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "WithDraw";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtbAccountNumber
            // 
            this.txtbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAccountNumber.Location = new System.Drawing.Point(183, 159);
            this.txtbAccountNumber.Name = "txtbAccountNumber";
            this.txtbAccountNumber.Size = new System.Drawing.Size(171, 22);
            this.txtbAccountNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount :";
            // 
            // txtbBalance
            // 
            this.txtbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBalance.Location = new System.Drawing.Point(183, 196);
            this.txtbBalance.Name = "txtbBalance";
            this.txtbBalance.Size = new System.Drawing.Size(171, 22);
            this.txtbBalance.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(130, 247);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(384, 12);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(389, 350);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 6;
            this.imgBox.TabStop = false;
            // 
            // btnVeaw
            // 
            this.btnVeaw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVeaw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVeaw.Location = new System.Drawing.Point(522, 368);
            this.btnVeaw.Name = "btnVeaw";
            this.btnVeaw.Size = new System.Drawing.Size(85, 31);
            this.btnVeaw.TabIndex = 7;
            this.btnVeaw.Text = "Veaw Details";
            this.btnVeaw.UseVisualStyleBackColor = false;
            this.btnVeaw.Click += new System.EventHandler(this.btnVeaw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "            Before WithDraw \r\n        Cheak Account Details";
            // 
            // WithDraw_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(785, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVeaw);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbAccountNumber);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "WithDraw_Amount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithDraw_Amount";
            this.Load += new System.EventHandler(this.Deposit_Amount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtbAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbBalance;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button btnVeaw;
        private System.Windows.Forms.Label label3;
    }
}