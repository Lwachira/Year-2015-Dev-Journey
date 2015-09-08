namespace s213200619_Baywest
{
    partial class frmRegister
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLoginID = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtRank = new MetroFramework.Controls.MetroTextBox();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "LoginID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Rank";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Lines = new string[0];
            this.txtLoginID.Location = new System.Drawing.Point(112, 107);
            this.txtLoginID.MaxLength = 32767;
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.PasswordChar = '\0';
            this.txtLoginID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginID.SelectedText = "";
            this.txtLoginID.Size = new System.Drawing.Size(101, 23);
            this.txtLoginID.TabIndex = 3;
            this.txtLoginID.UseSelectable = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(112, 152);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(101, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.UseSelectable = true;
            // 
            // txtRank
            // 
            this.txtRank.Lines = new string[0];
            this.txtRank.Location = new System.Drawing.Point(112, 195);
            this.txtRank.MaxLength = 32767;
            this.txtRank.Name = "txtRank";
            this.txtRank.PasswordChar = '\0';
            this.txtRank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRank.SelectedText = "";
            this.txtRank.Size = new System.Drawing.Size(101, 23);
            this.txtRank.TabIndex = 5;
            this.txtRank.UseSelectable = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(56, 265);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLoginID;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtRank;
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}