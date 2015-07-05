using System;
using System.Windows.Forms;

namespace Practical_8_Question_3
{
    partial class frmTriangle
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
            this.lstTriangle = new System.Windows.Forms.ListBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.btnPrv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTriangle
            // 
            this.lstTriangle.FormattingEnabled = true;
            this.lstTriangle.Location = new System.Drawing.Point(9, 47);
            this.lstTriangle.Name = "lstTriangle";
            this.lstTriangle.Size = new System.Drawing.Size(272, 173);
            this.lstTriangle.TabIndex = 0;
            // 
            // cmbStyle
            // 
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Items.AddRange(new object[] {
            "Right triangle",
            "Equilateral triangle",
            "Isosceles triangle",
            "Obtuse triangle",
            "Acute Triangle"});
            this.cmbStyle.Location = new System.Drawing.Point(85, 12);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbStyle.TabIndex = 1;
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(94, 226);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(102, 23);
            this.btnPrv.TabIndex = 2;
            this.btnPrv.Text = "Shapes Form";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click_1);
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.lstTriangle);
            this.Controls.Add(this.btnPrv);
            this.Name = "frmTriangle";
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.frmTriangle_Load);
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.ListBox lstTriangle;
        private TextBox txtHeight;
        private TextBox txtWidth;

   

        private ComboBox cmbStyle;
        private Button btnPrv;
    }
}