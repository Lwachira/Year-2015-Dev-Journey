namespace Practical_8_Question_1
{
    partial class Academic
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
            this.rdoLaw = new System.Windows.Forms.RadioButton();
            this.rdoAccounting = new System.Windows.Forms.RadioButton();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoLaw
            // 
            this.rdoLaw.AutoSize = true;
            this.rdoLaw.Location = new System.Drawing.Point(142, 44);
            this.rdoLaw.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLaw.Name = "rdoLaw";
            this.rdoLaw.Size = new System.Drawing.Size(123, 17);
            this.rdoLaw.TabIndex = 7;
            this.rdoLaw.TabStop = true;
            this.rdoLaw.Text = "Law Student Society";
            this.rdoLaw.UseVisualStyleBackColor = true;
            // 
            // rdoAccounting
            // 
            this.rdoAccounting.AutoSize = true;
            this.rdoAccounting.Location = new System.Drawing.Point(21, 44);
            this.rdoAccounting.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAccounting.Name = "rdoAccounting";
            this.rdoAccounting.Size = new System.Drawing.Size(117, 17);
            this.rdoAccounting.TabIndex = 6;
            this.rdoAccounting.TabStop = true;
            this.rdoAccounting.Text = "Accounting Society";
            this.rdoAccounting.UseVisualStyleBackColor = true;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(131, 92);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course Code";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(102, 170);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // Academic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rdoLaw);
            this.Controls.Add(this.rdoAccounting);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.label6);
            this.Name = "Academic";
            this.Text = "Academic";
            this.Load += new System.EventHandler(this.Academic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoLaw;
        private System.Windows.Forms.RadioButton rdoAccounting;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWrite;
    }
}