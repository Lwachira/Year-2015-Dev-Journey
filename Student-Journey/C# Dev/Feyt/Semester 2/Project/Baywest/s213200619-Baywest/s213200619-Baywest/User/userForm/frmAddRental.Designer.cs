namespace s213200619_Baywest.User.userForm
{
    partial class frmAddRental
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
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtRentalID = new System.Windows.Forms.MaskedTextBox();
            this.txtCustomerID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopID = new System.Windows.Forms.MaskedTextBox();
            this.dtRentalStartDate = new MetroFramework.Controls.MetroDateTime();
            this.dtRentalEndDate = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(66, 301);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 14;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(194, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "RentalID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "CustomerID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "ShopID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "RentalStartDate";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 225);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "RentalEndDate";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(110, 79);
            this.txtRentalID.Mask = "00000";
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(100, 20);
            this.txtRentalID.TabIndex = 21;
            this.txtRentalID.ValidatingType = typeof(int);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(110, 117);
            this.txtCustomerID.Mask = "00000";
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 22;
            this.txtCustomerID.ValidatingType = typeof(int);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(110, 151);
            this.txtShopID.Mask = "00000";
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 23;
            this.txtShopID.ValidatingType = typeof(int);
            // 
            // dtRentalStartDate
            // 
            this.dtRentalStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRentalStartDate.Location = new System.Drawing.Point(124, 181);
            this.dtRentalStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtRentalStartDate.Name = "dtRentalStartDate";
            this.dtRentalStartDate.Size = new System.Drawing.Size(200, 29);
            this.dtRentalStartDate.TabIndex = 24;
            // 
            // dtRentalEndDate
            // 
            this.dtRentalEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRentalEndDate.Location = new System.Drawing.Point(123, 216);
            this.dtRentalEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtRentalEndDate.Name = "dtRentalEndDate";
            this.dtRentalEndDate.Size = new System.Drawing.Size(200, 29);
            this.dtRentalEndDate.TabIndex = 25;
            // 
            // frmAddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.dtRentalEndDate);
            this.Controls.Add(this.dtRentalStartDate);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Name = "frmAddRental";
            this.Text = "Add Rental";
            this.Load += new System.EventHandler(this.frmAddRental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.MaskedTextBox txtRentalID;
        private System.Windows.Forms.MaskedTextBox txtCustomerID;
        private System.Windows.Forms.MaskedTextBox txtShopID;
        private MetroFramework.Controls.MetroDateTime dtRentalStartDate;
        private MetroFramework.Controls.MetroDateTime dtRentalEndDate;
    }
}