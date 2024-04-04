namespace BankSystem
{
    partial class AccountProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountProfile));
            this.sideBar = new System.Windows.Forms.Panel();
            this.SideBarContainer = new System.Windows.Forms.Panel();
            this.sidebarbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBalance = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.DashbourdTransfer = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.SideBarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarbtn)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.Controls.Add(this.SideBarContainer);
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Location = new System.Drawing.Point(3, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(186, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(67, 347);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(186, 347);
            this.sideBar.TabIndex = 1;
            // 
            // SideBarContainer
            // 
            this.SideBarContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SideBarContainer.Controls.Add(this.sidebarbtn);
            this.SideBarContainer.Controls.Add(this.label1);
            this.SideBarContainer.Controls.Add(this.panel4);
            this.SideBarContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SideBarContainer.Location = new System.Drawing.Point(2, 3);
            this.SideBarContainer.Name = "SideBarContainer";
            this.SideBarContainer.Size = new System.Drawing.Size(183, 85);
            this.SideBarContainer.TabIndex = 8;
            // 
            // sidebarbtn
            // 
            this.sidebarbtn.Image = ((System.Drawing.Image)(resources.GetObject("sidebarbtn.Image")));
            this.sidebarbtn.Location = new System.Drawing.Point(12, 21);
            this.sidebarbtn.Name = "sidebarbtn";
            this.sidebarbtn.Size = new System.Drawing.Size(43, 44);
            this.sidebarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarbtn.TabIndex = 4;
            this.sidebarbtn.TabStop = false;
            this.sidebarbtn.Click += new System.EventHandler(this.sidebarbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 89);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 57);
            this.panel4.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.btnTransfer);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Location = new System.Drawing.Point(0, 171);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(185, 71);
            this.panel9.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(1, 91);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 57);
            this.panel10.TabIndex = 3;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(1, 12);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(155, 52);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button7);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(1, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(182, 56);
            this.panel11.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(22, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 52);
            this.button7.TabIndex = 6;
            this.button7.Text = "Transfer";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(1, 91);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 57);
            this.panel12.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.btnBalance);
            this.panel5.Location = new System.Drawing.Point(1, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 67);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(1, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 57);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(1, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 56);
            this.panel7.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(22, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Transfer";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(1, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 57);
            this.panel8.TabIndex = 3;
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalance.Location = new System.Drawing.Point(0, 16);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(157, 48);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "Balance";
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.button1_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Tick += new System.EventHandler(this.SideBarEcpand);
            // 
            // DashbourdTransfer
            // 
            this.DashbourdTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashbourdTransfer.BackgroundImage")));
            this.DashbourdTransfer.Location = new System.Drawing.Point(190, 3);
            this.DashbourdTransfer.Name = "DashbourdTransfer";
            this.DashbourdTransfer.Size = new System.Drawing.Size(600, 344);
            this.DashbourdTransfer.TabIndex = 2;
            // 
            // AccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.DashbourdTransfer);
            this.Controls.Add(this.sideBar);
            this.Name = "AccountProfile";
            this.Size = new System.Drawing.Size(793, 350);
            this.Load += new System.EventHandler(this.AccountProfile_Load);
            this.sideBar.ResumeLayout(false);
            this.SideBarContainer.ResumeLayout(false);
            this.SideBarContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarbtn)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Panel SideBarContainer;
        private System.Windows.Forms.PictureBox sidebarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel DashbourdTransfer;
    }
}
