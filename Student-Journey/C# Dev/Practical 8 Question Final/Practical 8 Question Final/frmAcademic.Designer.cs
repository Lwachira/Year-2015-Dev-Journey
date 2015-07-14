namespace Practical_8_Question_Final
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
            this.grpAcademic = new System.Windows.Forms.GroupBox();
            this.rdoLaw = new System.Windows.Forms.RadioButton();
            this.rdoAccounting = new System.Windows.Forms.RadioButton();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAcademic.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAcademic
            // 
            this.grpAcademic.Controls.Add(this.rdoLaw);
            this.grpAcademic.Controls.Add(this.rdoAccounting);
            this.grpAcademic.Controls.Add(this.txtCourseCode);
            this.grpAcademic.Controls.Add(this.label6);
            this.grpAcademic.Location = new System.Drawing.Point(27, 43);
            this.grpAcademic.Name = "grpAcademic";
            this.grpAcademic.Size = new System.Drawing.Size(325, 136);
            this.grpAcademic.TabIndex = 16;
            this.grpAcademic.TabStop = false;
            this.grpAcademic.Text = "Academic";
            this.grpAcademic.Visible = false;
            // 
            // rdoLaw
            // 
            this.rdoLaw.AutoSize = true;
            this.rdoLaw.Location = new System.Drawing.Point(164, 18);
            this.rdoLaw.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLaw.Name = "rdoLaw";
            this.rdoLaw.Size = new System.Drawing.Size(123, 17);
            this.rdoLaw.TabIndex = 3;
            this.rdoLaw.TabStop = true;
            this.rdoLaw.Text = "Law Student Society";
            this.rdoLaw.UseVisualStyleBackColor = true;
            // 
            // rdoAccounting
            // 
            this.rdoAccounting.AutoSize = true;
            this.rdoAccounting.Location = new System.Drawing.Point(8, 19);
            this.rdoAccounting.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAccounting.Name = "rdoAccounting";
            this.rdoAccounting.Size = new System.Drawing.Size(117, 17);
            this.rdoAccounting.TabIndex = 2;
            this.rdoAccounting.TabStop = true;
            this.rdoAccounting.Text = "Accounting Society";
            this.rdoAccounting.UseVisualStyleBackColor = true;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(111, 69);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(150, 20);
            this.txtCourseCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Code";
            // 
            // frmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.grpAcademic);
            this.Name = "frmAcademic";
            this.Text = "Academic";
            this.Load += new System.EventHandler(this.frmAcademic_Load);
            this.grpAcademic.ResumeLayout(false);
            this.grpAcademic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAcademic;
        private System.Windows.Forms.RadioButton rdoLaw;
        private System.Windows.Forms.RadioButton rdoAccounting;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label6;

        public frmAcademic()
        {
        }
    }
}