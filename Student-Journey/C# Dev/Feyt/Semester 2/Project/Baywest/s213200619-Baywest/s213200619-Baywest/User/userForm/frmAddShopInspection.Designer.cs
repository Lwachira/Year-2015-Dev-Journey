namespace s213200619_Baywest.User.userForm
{
    partial class frmAddShopInspection
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtServiceID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopID = new System.Windows.Forms.MaskedTextBox();
            this.txtShopInspectionID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtMessage = new System.Windows.Forms.MaskedTextBox();
            this.txtInspectionTask = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Start Date";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(143, 148);
            this.txtServiceID.Mask = "00000";
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(100, 20);
            this.txtServiceID.TabIndex = 45;
            this.txtServiceID.ValidatingType = typeof(int);
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(143, 114);
            this.txtShopID.Mask = "00000";
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 44;
            this.txtShopID.ValidatingType = typeof(int);
            // 
            // txtShopInspectionID
            // 
            this.txtShopInspectionID.Location = new System.Drawing.Point(143, 76);
            this.txtShopInspectionID.Mask = "00000";
            this.txtShopInspectionID.Name = "txtShopInspectionID";
            this.txtShopInspectionID.Size = new System.Drawing.Size(100, 20);
            this.txtShopInspectionID.TabIndex = 43;
            this.txtShopInspectionID.ValidatingType = typeof(int);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Service ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Shop ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Inspection ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(187, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(59, 311);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 38;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(118, 177);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 29);
            this.dtStart.TabIndex = 47;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(118, 212);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 29);
            this.dtEnd.TabIndex = 49;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 222);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 48;
            this.metroLabel5.Text = "End Date";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(143, 273);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(102, 20);
            this.txtMessage.TabIndex = 53;
            this.txtMessage.ValidatingType = typeof(int);
            // 
            // txtInspectionTask
            // 
            this.txtInspectionTask.Location = new System.Drawing.Point(143, 247);
            this.txtInspectionTask.Name = "txtInspectionTask";
            this.txtInspectionTask.Size = new System.Drawing.Size(102, 20);
            this.txtInspectionTask.TabIndex = 52;
            this.txtInspectionTask.ValidatingType = typeof(int);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(44, 274);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "Message";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(44, 248);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.TabIndex = 50;
            this.metroLabel7.Text = "Inspection Task";
            // 
            // frmAddShopInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtInspectionTask);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.txtShopInspectionID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Name = "frmAddShopInspection";
            this.Text = "Add Shop Inspection";
            this.Load += new System.EventHandler(this.frmAddShopInspection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MaskedTextBox txtServiceID;
        private System.Windows.Forms.MaskedTextBox txtShopID;
        private System.Windows.Forms.MaskedTextBox txtShopInspectionID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.MaskedTextBox txtMessage;
        private System.Windows.Forms.MaskedTextBox txtInspectionTask;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}