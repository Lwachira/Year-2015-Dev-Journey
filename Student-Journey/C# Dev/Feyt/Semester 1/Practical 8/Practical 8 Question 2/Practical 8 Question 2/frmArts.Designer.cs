namespace Practical_8_Question_2
{
    partial class frmArts
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
            this.lstBoxArts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxArts
            // 
            this.lstBoxArts.FormattingEnabled = true;
            this.lstBoxArts.Location = new System.Drawing.Point(12, 12);
            this.lstBoxArts.Name = "lstBoxArts";
            this.lstBoxArts.Size = new System.Drawing.Size(973, 368);
            this.lstBoxArts.TabIndex = 0;
            // 
            // frmArts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 423);
            this.Controls.Add(this.lstBoxArts);
            this.Name = "frmArts";
            this.Text = "frmArts";
            this.Load += new System.EventHandler(this.frmArts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxArts;
    }
}