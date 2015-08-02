namespace Sem2Prac1
{
    partial class frmUpdateDoc
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocCellNum = new System.Windows.Forms.TextBox();
            this.txtDocFirstName = new System.Windows.Forms.TextBox();
            this.txtDocSurname = new System.Windows.Forms.TextBox();
            this.txtDocID = new System.Windows.Forms.TextBox();
            this.dgvDoctorView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Doctor Cell Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Doctor FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Doctor Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doctor ID";
            // 
            // txtDocCellNum
            // 
            this.txtDocCellNum.Location = new System.Drawing.Point(145, 181);
            this.txtDocCellNum.Name = "txtDocCellNum";
            this.txtDocCellNum.Size = new System.Drawing.Size(100, 20);
            this.txtDocCellNum.TabIndex = 11;
            // 
            // txtDocFirstName
            // 
            this.txtDocFirstName.Location = new System.Drawing.Point(145, 148);
            this.txtDocFirstName.Name = "txtDocFirstName";
            this.txtDocFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtDocFirstName.TabIndex = 10;
            // 
            // txtDocSurname
            // 
            this.txtDocSurname.Location = new System.Drawing.Point(145, 115);
            this.txtDocSurname.Name = "txtDocSurname";
            this.txtDocSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDocSurname.TabIndex = 9;
            // 
            // txtDocID
            // 
            this.txtDocID.Location = new System.Drawing.Point(145, 82);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.Size = new System.Drawing.Size(100, 20);
            this.txtDocID.TabIndex = 8;
            // 
            // dgvDoctorView
            // 
            this.dgvDoctorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorView.Location = new System.Drawing.Point(278, 51);
            this.dgvDoctorView.Name = "dgvDoctorView";
            this.dgvDoctorView.Size = new System.Drawing.Size(415, 207);
            this.dgvDoctorView.TabIndex = 16;
            this.dgvDoctorView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorView_CellClick);
            this.dgvDoctorView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorView_CellContentClick);
            this.dgvDoctorView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorView_RowEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Update Doctors";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 366);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDoctorView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocCellNum);
            this.Controls.Add(this.txtDocFirstName);
            this.Controls.Add(this.txtDocSurname);
            this.Controls.Add(this.txtDocID);
            this.Name = "frmUpdateDoc";
            this.Text = "frmUpdateDoc";
            this.Load += new System.EventHandler(this.frmUpdateDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocCellNum;
        private System.Windows.Forms.TextBox txtDocFirstName;
        private System.Windows.Forms.TextBox txtDocSurname;
        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.DataGridView dgvDoctorView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
    }
}