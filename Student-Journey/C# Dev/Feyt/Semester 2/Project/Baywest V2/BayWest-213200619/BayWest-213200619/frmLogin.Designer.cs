namespace BayWest_213200619
{
    partial class frmLogin
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
            this.mCmbUsername = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mCmbUsername
            // 
            this.mCmbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mCmbUsername.FormattingEnabled = true;
            this.mCmbUsername.ItemHeight = 23;
            this.mCmbUsername.Location = new System.Drawing.Point(363, 208);
            this.mCmbUsername.Name = "mCmbUsername";
            this.mCmbUsername.Size = new System.Drawing.Size(208, 29);
            this.mCmbUsername.TabIndex = 0;
            this.mCmbUsername.UseSelectable = true;
            this.mCmbUsername.SelectedIndexChanged += new System.EventHandler(this.mCmbUsername_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(268, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mCmbUsername);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mCmbUsername;
        private System.Windows.Forms.Label label1;
    }
}