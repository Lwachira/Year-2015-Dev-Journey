namespace s213200619_Baywest.User.userForm
{
    partial class frmAddShop
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
            this.txtShopSize = new System.Windows.Forms.MaskedTextBox();
            this.txtShopName = new System.Windows.Forms.MaskedTextBox();
            this.txtShopID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtShopSize
            // 
            this.txtShopSize.Location = new System.Drawing.Point(110, 155);
            this.txtShopSize.Mask = "00000";
            this.txtShopSize.Name = "txtShopSize";
            this.txtShopSize.Size = new System.Drawing.Size(100, 20);
            this.txtShopSize.TabIndex = 29;
            this.txtShopSize.ValidatingType = typeof(int);
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(110, 121);
            this.txtShopName.Mask = "00000";
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 28;
            this.txtShopName.ValidatingType = typeof(int);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(110, 83);
            this.txtShopID.Mask = "00000";
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 27;
            this.txtShopID.ValidatingType = typeof(int);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Shop Size";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Shop Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Shop ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(45, 282);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 30;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmAddShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtShopSize);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddShop";
            this.Text = "Add Shop";
            this.Load += new System.EventHandler(this.frmAddShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtShopSize;
        private System.Windows.Forms.MaskedTextBox txtShopName;
        private System.Windows.Forms.MaskedTextBox txtShopID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnWrite;
    }
}