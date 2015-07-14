namespace Practical_8_Question_Final
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
            this.grpArts = new System.Windows.Forms.GroupBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.rdoBallroom = new System.Windows.Forms.RadioButton();
            this.rdoMarimba = new System.Windows.Forms.RadioButton();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpArts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArts
            // 
            this.grpArts.Controls.Add(this.cmbLevel);
            this.grpArts.Controls.Add(this.rdoBallroom);
            this.grpArts.Controls.Add(this.rdoMarimba);
            this.grpArts.Controls.Add(this.txtWins);
            this.grpArts.Controls.Add(this.label8);
            this.grpArts.Controls.Add(this.label7);
            this.grpArts.Location = new System.Drawing.Point(12, 12);
            this.grpArts.Name = "grpArts";
            this.grpArts.Size = new System.Drawing.Size(359, 156);
            this.grpArts.TabIndex = 17;
            this.grpArts.TabStop = false;
            this.grpArts.Text = "Arts and Culture";
            this.grpArts.Visible = false;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(47, 93);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(92, 21);
            this.cmbLevel.TabIndex = 6;
            // 
            // rdoBallroom
            // 
            this.rdoBallroom.AutoSize = true;
            this.rdoBallroom.Location = new System.Drawing.Point(202, 31);
            this.rdoBallroom.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBallroom.Name = "rdoBallroom";
            this.rdoBallroom.Size = new System.Drawing.Size(103, 17);
            this.rdoBallroom.TabIndex = 5;
            this.rdoBallroom.TabStop = true;
            this.rdoBallroom.Text = "Ballroom Society";
            this.rdoBallroom.UseVisualStyleBackColor = true;
            // 
            // rdoMarimba
            // 
            this.rdoMarimba.AutoSize = true;
            this.rdoMarimba.Location = new System.Drawing.Point(26, 31);
            this.rdoMarimba.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMarimba.Name = "rdoMarimba";
            this.rdoMarimba.Size = new System.Drawing.Size(103, 17);
            this.rdoMarimba.TabIndex = 4;
            this.rdoMarimba.TabStop = true;
            this.rdoMarimba.Text = "Marimba Society";
            this.rdoMarimba.UseVisualStyleBackColor = true;
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(253, 92);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(87, 20);
            this.txtWins.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wins";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Level";
            // 
            // frmArts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.grpArts);
            this.Name = "frmArts";
            this.Text = "Arts";
            this.Load += new System.EventHandler(this.frmArts_Load);
            this.grpArts.ResumeLayout(false);
            this.grpArts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArts;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.RadioButton rdoBallroom;
        private System.Windows.Forms.RadioButton rdoMarimba;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

        public frmArts(string studNo, string studName, string studDegree)
        {
            this.studNo = studNo;
            this.studName = studName;
            this.studDegree = studDegree;
            InitializeComponent();
        }
    }
}