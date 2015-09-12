namespace s213200619_Baywest.User.userForm
{
    partial class frmAddShopService
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
            this.txtServiceID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopServiceID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.txtServiceName = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(122, 146);
            this.txtServiceID.Mask = "00000";
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(100, 20);
            this.txtServiceID.TabIndex = 35;
            this.txtServiceID.ValidatingType = typeof(int);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(122, 112);
            this.txtShopID.Mask = "00000";
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 34;
            this.txtShopID.ValidatingType = typeof(int);
            // 
            // txtShopServiceID
            // 
            this.txtShopServiceID.Location = new System.Drawing.Point(122, 74);
            this.txtShopServiceID.Mask = "00000";
            this.txtShopServiceID.Name = "txtShopServiceID";
            this.txtShopServiceID.Size = new System.Drawing.Size(100, 20);
            this.txtShopServiceID.TabIndex = 33;
            this.txtShopServiceID.ValidatingType = typeof(int);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Service ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Shop ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "ShopService ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(194, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(66, 296);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 26;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(122, 185);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 20);
            this.txtServiceName.TabIndex = 37;
            this.txtServiceName.ValidatingType = typeof(int);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 185);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Service Name";
            // 
            // frmAddShopService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.txtShopServiceID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Name = "frmAddShopService";
            this.Text = "Shop Service";
            this.Load += new System.EventHandler(this.frmShopService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtServiceID;
        private System.Windows.Forms.MaskedTextBox txtShopID;
        private System.Windows.Forms.MaskedTextBox txtShopServiceID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnWrite;
        private System.Windows.Forms.MaskedTextBox txtServiceName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}