namespace Practical_8_Question_Final
{
    partial class Form1
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
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnArts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(25, 215);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(75, 23);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Text = "Accounting";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnArts
            // 
            this.btnArts.Location = new System.Drawing.Point(183, 215);
            this.btnArts.Name = "btnArts";
            this.btnArts.Size = new System.Drawing.Size(75, 23);
            this.btnArts.TabIndex = 1;
            this.btnArts.Text = "Arts";
            this.btnArts.UseVisualStyleBackColor = true;
            this.btnArts.Click += new System.EventHandler(this.btnArts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the form and society that you would like.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Degree";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(101, 17);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNo.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(101, 65);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(157, 20);
            this.txtDegree.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArts);
            this.Controls.Add(this.btnAcc);
            this.Name = "Form1";
            this.Text = "Socities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnArts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDegree;
    }
}

