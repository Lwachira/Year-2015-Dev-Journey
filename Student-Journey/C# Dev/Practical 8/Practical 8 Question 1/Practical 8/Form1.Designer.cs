namespace Practical_8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rdoMarimba = new System.Windows.Forms.RadioButton();
            this.rdoAccounting = new System.Windows.Forms.RadioButton();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artsAndCultureStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkArts = new System.Windows.Forms.CheckBox();
            this.chkAcademic = new System.Windows.Forms.CheckBox();
            this.rdoLaw = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.grpArts = new System.Windows.Forms.GroupBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.rdoBallroom = new System.Windows.Forms.RadioButton();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAcademic = new System.Windows.Forms.GroupBox();
            this.dgvAllStudents = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.grpAddStudents = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAcademic = new System.Windows.Forms.DataGridView();
            this.dgvArts = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuNavigation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpArts.SuspendLayout();
            this.grpAcademic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.grpAddStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoMarimba
            // 
            this.rdoMarimba.AutoSize = true;
            this.rdoMarimba.Location = new System.Drawing.Point(12, 18);
            this.rdoMarimba.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMarimba.Name = "rdoMarimba";
            this.rdoMarimba.Size = new System.Drawing.Size(103, 17);
            this.rdoMarimba.TabIndex = 4;
            this.rdoMarimba.TabStop = true;
            this.rdoMarimba.Text = "Marimba Society";
            this.rdoMarimba.UseVisualStyleBackColor = true;
            this.rdoMarimba.UseWaitCursor = true;
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
            this.rdoAccounting.UseWaitCursor = true;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(77, 48);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 1;
            this.txtCourseCode.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Degree";
            this.label4.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Code";
            this.label6.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student No";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Name";
            this.label3.UseWaitCursor = true;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(91, 10);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNo.TabIndex = 10;
            this.txtStudentNo.UseWaitCursor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 11;
            this.txtName.UseWaitCursor = true;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(91, 58);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(157, 20);
            this.txtDegree.TabIndex = 12;
            this.txtDegree.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuNavigation.Size = new System.Drawing.Size(978, 24);
            this.mnuNavigation.TabIndex = 35;
            this.mnuNavigation.Text = "mnuNavigation";
            this.mnuNavigation.UseWaitCursor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStudentsToolStripMenuItem,
            this.academicStudentsToolStripMenuItem,
            this.artsAndCultureStudentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allStudentsToolStripMenuItem
            // 
            this.allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            this.allStudentsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.allStudentsToolStripMenuItem.Text = "All Students";
            this.allStudentsToolStripMenuItem.Click += new System.EventHandler(this.allStudentsToolStripMenuItem_Click);
            // 
            // academicStudentsToolStripMenuItem
            // 
            this.academicStudentsToolStripMenuItem.Name = "academicStudentsToolStripMenuItem";
            this.academicStudentsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.academicStudentsToolStripMenuItem.Text = "Academic Students";
            this.academicStudentsToolStripMenuItem.Click += new System.EventHandler(this.academicStudentsToolStripMenuItem_Click);
            // 
            // artsAndCultureStudentsToolStripMenuItem
            // 
            this.artsAndCultureStudentsToolStripMenuItem.Name = "artsAndCultureStudentsToolStripMenuItem";
            this.artsAndCultureStudentsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.artsAndCultureStudentsToolStripMenuItem.Text = "Arts and Culture Students";
            this.artsAndCultureStudentsToolStripMenuItem.Click += new System.EventHandler(this.artsAndCultureStudentsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkArts);
            this.groupBox1.Controls.Add(this.chkAcademic);
            this.groupBox1.Location = new System.Drawing.Point(91, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 42);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Societies";
            this.groupBox1.UseWaitCursor = true;
            // 
            // chkArts
            // 
            this.chkArts.AutoSize = true;
            this.chkArts.Location = new System.Drawing.Point(93, 19);
            this.chkArts.Margin = new System.Windows.Forms.Padding(2);
            this.chkArts.Name = "chkArts";
            this.chkArts.Size = new System.Drawing.Size(101, 17);
            this.chkArts.TabIndex = 11;
            this.chkArts.Text = "Arts and Culture";
            this.chkArts.UseVisualStyleBackColor = true;
            this.chkArts.UseWaitCursor = true;
            this.chkArts.CheckedChanged += new System.EventHandler(this.chkArts_CheckedChanged);
            // 
            // chkAcademic
            // 
            this.chkAcademic.AutoSize = true;
            this.chkAcademic.Location = new System.Drawing.Point(5, 19);
            this.chkAcademic.Margin = new System.Windows.Forms.Padding(2);
            this.chkAcademic.Name = "chkAcademic";
            this.chkAcademic.Size = new System.Drawing.Size(73, 17);
            this.chkAcademic.TabIndex = 10;
            this.chkAcademic.Text = "Academic";
            this.chkAcademic.UseVisualStyleBackColor = true;
            this.chkAcademic.UseWaitCursor = true;
            this.chkAcademic.CheckedChanged += new System.EventHandler(this.chkAcademic_CheckedChanged);
            // 
            // rdoLaw
            // 
            this.rdoLaw.AutoSize = true;
            this.rdoLaw.Location = new System.Drawing.Point(130, 18);
            this.rdoLaw.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLaw.Name = "rdoLaw";
            this.rdoLaw.Size = new System.Drawing.Size(123, 17);
            this.rdoLaw.TabIndex = 3;
            this.rdoLaw.TabStop = true;
            this.rdoLaw.Text = "Law Student Society";
            this.rdoLaw.UseVisualStyleBackColor = true;
            this.rdoLaw.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Arts and Culture Societies";
            this.label10.UseWaitCursor = true;
            // 
            // grpArts
            // 
            this.grpArts.Controls.Add(this.cmbLevel);
            this.grpArts.Controls.Add(this.rdoBallroom);
            this.grpArts.Controls.Add(this.rdoMarimba);
            this.grpArts.Controls.Add(this.txtWins);
            this.grpArts.Controls.Add(this.label8);
            this.grpArts.Controls.Add(this.label7);
            this.grpArts.Location = new System.Drawing.Point(312, 100);
            this.grpArts.Name = "grpArts";
            this.grpArts.Size = new System.Drawing.Size(255, 86);
            this.grpArts.TabIndex = 16;
            this.grpArts.TabStop = false;
            this.grpArts.Text = "Arts and Culture";
            this.grpArts.UseWaitCursor = true;
            this.grpArts.Visible = false;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(46, 48);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(92, 21);
            this.cmbLevel.TabIndex = 6;
            this.cmbLevel.UseWaitCursor = true;
            // 
            // rdoBallroom
            // 
            this.rdoBallroom.AutoSize = true;
            this.rdoBallroom.Location = new System.Drawing.Point(130, 18);
            this.rdoBallroom.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBallroom.Name = "rdoBallroom";
            this.rdoBallroom.Size = new System.Drawing.Size(103, 17);
            this.rdoBallroom.TabIndex = 5;
            this.rdoBallroom.TabStop = true;
            this.rdoBallroom.Text = "Ballroom Society";
            this.rdoBallroom.UseVisualStyleBackColor = true;
            this.rdoBallroom.UseWaitCursor = true;
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(180, 50);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(61, 20);
            this.txtWins.TabIndex = 3;
            this.txtWins.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wins";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Level";
            this.label7.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Societies ";
            this.label5.UseWaitCursor = true;
            // 
            // grpAcademic
            // 
            this.grpAcademic.Controls.Add(this.rdoLaw);
            this.grpAcademic.Controls.Add(this.rdoAccounting);
            this.grpAcademic.Controls.Add(this.txtCourseCode);
            this.grpAcademic.Controls.Add(this.label6);
            this.grpAcademic.Location = new System.Drawing.Point(312, 11);
            this.grpAcademic.Name = "grpAcademic";
            this.grpAcademic.Size = new System.Drawing.Size(255, 82);
            this.grpAcademic.TabIndex = 15;
            this.grpAcademic.TabStop = false;
            this.grpAcademic.Text = "Academic";
            this.grpAcademic.UseWaitCursor = true;
            this.grpAcademic.Visible = false;
            // 
            // dgvAllStudents
            // 
            this.dgvAllStudents.AllowUserToAddRows = false;
            this.dgvAllStudents.AllowUserToDeleteRows = false;
            this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStudents.Location = new System.Drawing.Point(590, 70);
            this.dgvAllStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.ReadOnly = true;
            this.dgvAllStudents.RowTemplate.Height = 24;
            this.dgvAllStudents.Size = new System.Drawing.Size(380, 500);
            this.dgvAllStudents.TabIndex = 39;
            this.dgvAllStudents.UseWaitCursor = true;
            this.dgvAllStudents.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Academic Societies";
            this.label9.UseWaitCursor = true;
            // 
            // grpAddStudents
            // 
            this.grpAddStudents.Controls.Add(this.label2);
            this.grpAddStudents.Controls.Add(this.label3);
            this.grpAddStudents.Controls.Add(this.label4);
            this.grpAddStudents.Controls.Add(this.txtStudentNo);
            this.grpAddStudents.Controls.Add(this.txtName);
            this.grpAddStudents.Controls.Add(this.txtDegree);
            this.grpAddStudents.Controls.Add(this.btnAdd);
            this.grpAddStudents.Controls.Add(this.groupBox1);
            this.grpAddStudents.Controls.Add(this.grpArts);
            this.grpAddStudents.Controls.Add(this.label5);
            this.grpAddStudents.Controls.Add(this.grpAcademic);
            this.grpAddStudents.Location = new System.Drawing.Point(9, 64);
            this.grpAddStudents.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddStudents.Name = "grpAddStudents";
            this.grpAddStudents.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddStudents.Size = new System.Drawing.Size(576, 195);
            this.grpAddStudents.TabIndex = 42;
            this.grpAddStudents.TabStop = false;
            this.grpAddStudents.UseWaitCursor = true;
            this.grpAddStudents.Enter += new System.EventHandler(this.grpAddStudents_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Student Societies Registration";
            this.label1.UseWaitCursor = true;
            // 
            // dgvAcademic
            // 
            this.dgvAcademic.AllowUserToAddRows = false;
            this.dgvAcademic.AllowUserToDeleteRows = false;
            this.dgvAcademic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademic.Location = new System.Drawing.Point(12, 277);
            this.dgvAcademic.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAcademic.Name = "dgvAcademic";
            this.dgvAcademic.ReadOnly = true;
            this.dgvAcademic.RowTemplate.Height = 24;
            this.dgvAcademic.Size = new System.Drawing.Size(521, 132);
            this.dgvAcademic.TabIndex = 37;
            this.dgvAcademic.UseWaitCursor = true;
            this.dgvAcademic.Visible = false;
            // 
            // dgvArts
            // 
            this.dgvArts.AllowUserToAddRows = false;
            this.dgvArts.AllowUserToDeleteRows = false;
            this.dgvArts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArts.Location = new System.Drawing.Point(9, 448);
            this.dgvArts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArts.Name = "dgvArts";
            this.dgvArts.ReadOnly = true;
            this.dgvArts.RowTemplate.Height = 24;
            this.dgvArts.Size = new System.Drawing.Size(524, 122);
            this.dgvArts.TabIndex = 38;
            this.dgvArts.UseWaitCursor = true;
            this.dgvArts.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 578);
            this.Controls.Add(this.mnuNavigation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvAllStudents);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpAddStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAcademic);
            this.Controls.Add(this.dgvArts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpArts.ResumeLayout(false);
            this.grpArts.PerformLayout();
            this.grpAcademic.ResumeLayout(false);
            this.grpAcademic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.grpAddStudents.ResumeLayout(false);
            this.grpAddStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoMarimba;
        private System.Windows.Forms.RadioButton rdoAccounting;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artsAndCultureStudentsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkArts;
        private System.Windows.Forms.CheckBox chkAcademic;
        private System.Windows.Forms.RadioButton rdoLaw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpArts;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.RadioButton rdoBallroom;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpAcademic;
        private System.Windows.Forms.DataGridView dgvAllStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpAddStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAcademic;
        private System.Windows.Forms.DataGridView dgvArts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

