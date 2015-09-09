namespace s213200619_Baywest.User.userForm
{
    partial class frmAddUser
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
            this.txtLoginID = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerCellNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtLoginID
            // 
            this.txtLoginID.Lines = new string[0];
            this.txtLoginID.Location = new System.Drawing.Point(158, 182);
            this.txtLoginID.MaxLength = 32767;
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.PasswordChar = '\0';
            this.txtLoginID.ReadOnly = true;
            this.txtLoginID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginID.SelectedText = "";
            this.txtLoginID.Size = new System.Drawing.Size(100, 23);
            this.txtLoginID.TabIndex = 17;
            this.txtLoginID.UseSelectable = true;
            // 
            // txtCustomerCellNumber
            // 
            this.txtCustomerCellNumber.Lines = new string[0];
            this.txtCustomerCellNumber.Location = new System.Drawing.Point(159, 152);
            this.txtCustomerCellNumber.MaxLength = 32767;
            this.txtCustomerCellNumber.Name = "txtCustomerCellNumber";
            this.txtCustomerCellNumber.PasswordChar = '\0';
            this.txtCustomerCellNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerCellNumber.SelectedText = "";
            this.txtCustomerCellNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerCellNumber.TabIndex = 16;
            this.txtCustomerCellNumber.UseSelectable = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(159, 121);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerName.TabIndex = 15;
            this.txtCustomerName.UseSelectable = true;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(158, 95);
            this.txtCustomerID.Mask = "00000";
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 14;
            this.txtCustomerID.ValidatingType = typeof(int);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "LoginID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "CustomerCell";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "CustomerName";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "CustomerID";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(113, 243);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 18;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.txtCustomerCellNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtLoginID;
        private MetroFramework.Controls.MetroTextBox txtCustomerCellNumber;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private System.Windows.Forms.MaskedTextBox txtCustomerID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnWrite;
    }
}