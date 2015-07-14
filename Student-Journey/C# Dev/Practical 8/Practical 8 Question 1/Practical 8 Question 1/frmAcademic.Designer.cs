namespace Practical_8_Question_1
{
    partial class frmAcademic
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
            this.rdoAcc = new System.Windows.Forms.RadioButton();
            this.rdLaw = new System.Windows.Forms.RadioButton();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoAcc
            // 
            this.rdoAcc.AutoSize = true;
            this.rdoAcc.Location = new System.Drawing.Point(12, 54);
            this.rdoAcc.Name = "rdoAcc";
            this.rdoAcc.Size = new System.Drawing.Size(117, 17);
            this.rdoAcc.TabIndex = 0;
            this.rdoAcc.TabStop = true;
            this.rdoAcc.Text = "Accounting Society";
            this.rdoAcc.UseVisualStyleBackColor = true;
            // 
            // rdLaw
            // 
            this.rdLaw.AutoSize = true;
            this.rdLaw.Location = new System.Drawing.Point(154, 54);
            this.rdLaw.Name = "rdLaw";
            this.rdLaw.Size = new System.Drawing.Size(123, 17);
            this.rdLaw.TabIndex = 1;
            this.rdLaw.TabStop = true;
            this.rdLaw.Text = "Law Student Society";
            this.rdLaw.UseVisualStyleBackColor = true;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(126, 111);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Code";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(101, 173);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.rdLaw);
            this.Controls.Add(this.rdoAcc);
            this.Name = "frmAcademic";
            this.Text = "frmAcademic";
            this.Load += new System.EventHandler(this.frmAcademic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoAcc;
        private System.Windows.Forms.RadioButton rdLaw;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWrite;
    }
}