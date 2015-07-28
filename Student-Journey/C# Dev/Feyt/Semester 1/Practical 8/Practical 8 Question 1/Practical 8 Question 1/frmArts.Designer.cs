namespace Practical_8_Question_1
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
            this.rdoMarimba = new System.Windows.Forms.RadioButton();
            this.rdBallroom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoMarimba
            // 
            this.rdoMarimba.AutoSize = true;
            this.rdoMarimba.Location = new System.Drawing.Point(12, 25);
            this.rdoMarimba.Name = "rdoMarimba";
            this.rdoMarimba.Size = new System.Drawing.Size(103, 17);
            this.rdoMarimba.TabIndex = 0;
            this.rdoMarimba.TabStop = true;
            this.rdoMarimba.Text = "Marimba Society";
            this.rdoMarimba.UseVisualStyleBackColor = true;
            // 
            // rdBallroom
            // 
            this.rdBallroom.AutoSize = true;
            this.rdBallroom.Location = new System.Drawing.Point(171, 25);
            this.rdBallroom.Name = "rdBallroom";
            this.rdBallroom.Size = new System.Drawing.Size(103, 17);
            this.rdBallroom.TabIndex = 1;
            this.rdBallroom.TabStop = true;
            this.rdBallroom.Text = "Ballroom Society";
            this.rdBallroom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Levels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wins";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(84, 107);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(121, 20);
            this.txtWins.TabIndex = 4;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbLevel.Location = new System.Drawing.Point(84, 77);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbLevel.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(101, 165);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmArts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBallroom);
            this.Controls.Add(this.rdoMarimba);
            this.Name = "frmArts";
            this.Text = "frmArts";
            this.Load += new System.EventHandler(this.frmArts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoMarimba;
        private System.Windows.Forms.RadioButton rdBallroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnWrite;
    }
}