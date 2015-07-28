namespace Practical_8_Question_2
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
            this.lstBoxAcademic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxAcademic
            // 
            this.lstBoxAcademic.FormattingEnabled = true;
            this.lstBoxAcademic.Location = new System.Drawing.Point(5, 12);
            this.lstBoxAcademic.Name = "lstBoxAcademic";
            this.lstBoxAcademic.Size = new System.Drawing.Size(976, 277);
            this.lstBoxAcademic.TabIndex = 0;
            // 
            // frmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 344);
            this.Controls.Add(this.lstBoxAcademic);
            this.Name = "frmAcademic";
            this.Text = "Academic";
            this.Load += new System.EventHandler(this.Academic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxAcademic;
    }
}