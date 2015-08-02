namespace Sem2Prac1
{
    partial class frmAddDoctors
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
            this.txtDocID = new System.Windows.Forms.TextBox();
            this.txtDocSurname = new System.Windows.Forms.TextBox();
            this.txtDocFirstName = new System.Windows.Forms.TextBox();
            this.txtDocCellNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDocID
            // 
            this.txtDocID.Location = new System.Drawing.Point(138, 22);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.Size = new System.Drawing.Size(100, 20);
            this.txtDocID.TabIndex = 0;
            // 
            // txtDocSurname
            // 
            this.txtDocSurname.Location = new System.Drawing.Point(138, 55);
            this.txtDocSurname.Name = "txtDocSurname";
            this.txtDocSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDocSurname.TabIndex = 1;
            // 
            // txtDocFirstName
            // 
            this.txtDocFirstName.Location = new System.Drawing.Point(138, 88);
            this.txtDocFirstName.Name = "txtDocFirstName";
            this.txtDocFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtDocFirstName.TabIndex = 2;
            // 
            // txtDocCellNum
            // 
            this.txtDocCellNum.Location = new System.Drawing.Point(138, 121);
            this.txtDocCellNum.Name = "txtDocCellNum";
            this.txtDocCellNum.Size = new System.Drawing.Size(100, 20);
            this.txtDocCellNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doctor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doctor FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doctor Cell Number";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(106, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmAddDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 265);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocCellNum);
            this.Controls.Add(this.txtDocFirstName);
            this.Controls.Add(this.txtDocSurname);
            this.Controls.Add(this.txtDocID);
            this.Name = "frmAddDoctors";
            this.Text = "frmAddDoctors";
            this.Load += new System.EventHandler(this.frmAddDoctors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.TextBox txtDocSurname;
        private System.Windows.Forms.TextBox txtDocFirstName;
        private System.Windows.Forms.TextBox txtDocCellNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
    }
}