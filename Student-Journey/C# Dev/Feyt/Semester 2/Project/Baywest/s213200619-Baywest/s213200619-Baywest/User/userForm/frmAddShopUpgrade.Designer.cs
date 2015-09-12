namespace s213200619_Baywest.User.userForm
{
    partial class frmAddShopUpgrade
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
            this.txtMessage = new System.Windows.Forms.MaskedTextBox();
            this.txtUpgradeTask = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtServiceID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopUpgradeID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(122, 257);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(102, 20);
            this.txtMessage.TabIndex = 69;
            this.txtMessage.ValidatingType = typeof(int);
            // 
            // txtUpgradeTask
            // 
            this.txtUpgradeTask.Location = new System.Drawing.Point(122, 231);
            this.txtUpgradeTask.Name = "txtUpgradeTask";
            this.txtUpgradeTask.Size = new System.Drawing.Size(102, 20);
            this.txtUpgradeTask.TabIndex = 68;
            this.txtUpgradeTask.ValidatingType = typeof(int);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 258);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 67;
            this.metroLabel6.Text = "Message";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 232);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 19);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Upgrade Task";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(97, 196);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 29);
            this.dtEnd.TabIndex = 65;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 206);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 64;
            this.metroLabel5.Text = "End Date";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(97, 161);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 29);
            this.dtStart.TabIndex = 63;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "Start Date";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(122, 132);
            this.txtServiceID.Mask = "00000";
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(100, 20);
            this.txtServiceID.TabIndex = 61;
            this.txtServiceID.ValidatingType = typeof(int);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(122, 98);
            this.txtShopID.Mask = "00000";
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 60;
            this.txtShopID.ValidatingType = typeof(int);
            // 
            // txtShopUpgradeID
            // 
            this.txtShopUpgradeID.Location = new System.Drawing.Point(122, 60);
            this.txtShopUpgradeID.Mask = "00000";
            this.txtShopUpgradeID.Name = "txtShopUpgradeID";
            this.txtShopUpgradeID.Size = new System.Drawing.Size(100, 20);
            this.txtShopUpgradeID.TabIndex = 59;
            this.txtShopUpgradeID.ValidatingType = typeof(int);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Service ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "Shop ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Upgrade ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(38, 295);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 54;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmAddShopUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtUpgradeTask);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.txtShopUpgradeID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Name = "frmAddShopUpgrade";
            this.Text = "Add Shop Upgrade";
            this.Load += new System.EventHandler(this.frmAddShopUpgrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtMessage;
        private System.Windows.Forms.MaskedTextBox txtUpgradeTask;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MaskedTextBox txtServiceID;
        private System.Windows.Forms.MaskedTextBox txtShopID;
        private System.Windows.Forms.MaskedTextBox txtShopUpgradeID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnWrite;
    }
}