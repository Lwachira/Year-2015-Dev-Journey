namespace Practical_6___SD___Database_Access
{
    partial class SingleViewForms
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
            this.lstProd = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProd
            // 
            this.lstProd.FormattingEnabled = true;
            this.lstProd.Location = new System.Drawing.Point(36, 12);
            this.lstProd.Name = "lstProd";
            this.lstProd.Size = new System.Drawing.Size(212, 160);
            this.lstProd.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(152, 178);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(36, 178);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPrv.TabIndex = 2;
            this.btnPrv.Text = "Previous";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // SingleViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lstProd);
            this.Name = "SingleViewForms";
            this.Text = "SingleView";
            this.Load += new System.EventHandler(this.SingleViewForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
    }
}