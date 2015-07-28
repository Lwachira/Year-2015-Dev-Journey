using System.Windows.Forms;

namespace Practical_8_Question_3
{
    partial class frmRectangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtHeight;
        private TextBox txtWidth;

        


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
            this.lstRec = new System.Windows.Forms.ListBox();
            this.btnPrv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRec
            // 
            this.lstRec.FormattingEnabled = true;
            this.lstRec.Location = new System.Drawing.Point(12, 12);
            this.lstRec.Name = "lstRec";
            this.lstRec.Size = new System.Drawing.Size(260, 186);
            this.lstRec.TabIndex = 0;
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(99, 204);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPrv.TabIndex = 1;
            this.btnPrv.Text = "Shapes Form";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.lstRec);
            this.Name = "frmRectangle";
            this.Text = "Rectangle";
            this.Load += new System.EventHandler(this.frmRectangle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstRec;
        private Button btnPrv;
    }
}