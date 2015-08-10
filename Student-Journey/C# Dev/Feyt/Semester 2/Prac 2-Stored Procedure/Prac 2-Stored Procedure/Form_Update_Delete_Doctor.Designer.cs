namespace Prac_2_Stored_Procedure
{
    partial class Form_Update_Delete_Doctor
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
            this.dgvUpdateDoc = new System.Windows.Forms.DataGridView();
            this.txtDocID = new System.Windows.Forms.TextBox();
            this.txtDocSurname = new System.Windows.Forms.TextBox();
            this.txtDocFirstName = new System.Windows.Forms.TextBox();
            this.txtDocCellNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateDoc
            // 
            this.dgvUpdateDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateDoc.Location = new System.Drawing.Point(12, 12);
            this.dgvUpdateDoc.Name = "dgvUpdateDoc";
            this.dgvUpdateDoc.Size = new System.Drawing.Size(515, 336);
            this.dgvUpdateDoc.TabIndex = 0;
            this.dgvUpdateDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateDoc_CellClick);
            this.dgvUpdateDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateDoc_CellContentClick);
            // 
            // txtDocID
            // 
            this.txtDocID.Location = new System.Drawing.Point(556, 60);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.Size = new System.Drawing.Size(100, 20);
            this.txtDocID.TabIndex = 1;
            // 
            // txtDocSurname
            // 
            this.txtDocSurname.Location = new System.Drawing.Point(556, 114);
            this.txtDocSurname.Name = "txtDocSurname";
            this.txtDocSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDocSurname.TabIndex = 2;
            // 
            // txtDocFirstName
            // 
            this.txtDocFirstName.Location = new System.Drawing.Point(556, 167);
            this.txtDocFirstName.Name = "txtDocFirstName";
            this.txtDocFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtDocFirstName.TabIndex = 3;
            // 
            // txtDocCellNum
            // 
            this.txtDocCellNum.Location = new System.Drawing.Point(556, 228);
            this.txtDocCellNum.Name = "txtDocCellNum";
            this.txtDocCellNum.Size = new System.Drawing.Size(100, 20);
            this.txtDocCellNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doctor Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doctor First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doctor Cell Num";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(556, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(679, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Refresh";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(626, 325);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form_Update_Delete_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 360);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocCellNum);
            this.Controls.Add(this.txtDocFirstName);
            this.Controls.Add(this.txtDocSurname);
            this.Controls.Add(this.txtDocID);
            this.Controls.Add(this.dgvUpdateDoc);
            this.Name = "Form_Update_Delete_Doctor";
            this.Text = "Form_Update_Delete_Doctor";
            this.Load += new System.EventHandler(this.Form_Update_Delete_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateDoc;
        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.TextBox txtDocSurname;
        private System.Windows.Forms.TextBox txtDocFirstName;
        private System.Windows.Forms.TextBox txtDocCellNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}