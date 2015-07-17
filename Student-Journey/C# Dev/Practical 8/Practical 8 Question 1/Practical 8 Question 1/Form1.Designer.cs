namespace Practical_8_Question_1
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
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudNumber = new System.Windows.Forms.TextBox();
            this.txtStudentDegree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcademic = new System.Windows.Forms.Button();
            this.btnArts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(12, 26);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(100, 20);
            this.txtStudName.TabIndex = 0;
            // 
            // txtStudNumber
            // 
            this.txtStudNumber.Location = new System.Drawing.Point(12, 52);
            this.txtStudNumber.Name = "txtStudNumber";
            this.txtStudNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudNumber.TabIndex = 1;
            // 
            // txtStudentDegree
            // 
            this.txtStudentDegree.Location = new System.Drawing.Point(12, 78);
            this.txtStudentDegree.Name = "txtStudentDegree";
            this.txtStudentDegree.Size = new System.Drawing.Size(100, 20);
            this.txtStudentDegree.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Degree";
            // 
            // btnAcademic
            // 
            this.btnAcademic.Location = new System.Drawing.Point(37, 177);
            this.btnAcademic.Name = "btnAcademic";
            this.btnAcademic.Size = new System.Drawing.Size(75, 23);
            this.btnAcademic.TabIndex = 6;
            this.btnAcademic.Text = "Academic";
            this.btnAcademic.UseVisualStyleBackColor = true;
            this.btnAcademic.Click += new System.EventHandler(this.btnAcademic_Click);
            // 
            // btnArts
            // 
            this.btnArts.Location = new System.Drawing.Point(162, 177);
            this.btnArts.Name = "btnArts";
            this.btnArts.Size = new System.Drawing.Size(75, 23);
            this.btnArts.TabIndex = 7;
            this.btnArts.Text = "Arts";
            this.btnArts.UseVisualStyleBackColor = true;
            this.btnArts.Click += new System.EventHandler(this.btnArts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chose your Society:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnArts);
            this.Controls.Add(this.btnAcademic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentDegree);
            this.Controls.Add(this.txtStudNumber);
            this.Controls.Add(this.txtStudName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtStudNumber;
        private System.Windows.Forms.TextBox txtStudentDegree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcademic;
        private System.Windows.Forms.Button btnArts;
        private System.Windows.Forms.Label label4;
    }
}

