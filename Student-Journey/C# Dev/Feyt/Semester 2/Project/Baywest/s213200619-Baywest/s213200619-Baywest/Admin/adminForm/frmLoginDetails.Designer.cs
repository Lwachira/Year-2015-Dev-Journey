namespace s213200619_Baywest.Admin.adminForm
{
    partial class frmLoginDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnDeletedUser = new MetroFramework.Controls.MetroButton();
            this.btnNewUser = new MetroFramework.Controls.MetroButton();
            this.metroTxtRank = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDgvRequestLogin = new MetroFramework.Controls.MetroGrid();
            this.metroDgvLogin = new MetroFramework.Controls.MetroGrid();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroDgvRequestLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroDgvLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.metroDgvRequestLogin);
            this.splitContainer1.Panel2.Controls.Add(this.metroDgvLogin);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Size = new System.Drawing.Size(817, 384);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Controls.Add(this.metroTxtRank);
            this.metroPanel1.Controls.Add(this.metroTxtUserName);
            this.metroPanel1.Controls.Add(this.metroTxtID);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(266, 378);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 185);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(242, 176);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnRefresh);
            this.metroTabPage1.Controls.Add(this.btnDelete);
            this.metroTabPage1.Controls.Add(this.btnUpdate);
            this.metroTabPage1.Controls.Add(this.btnInsert);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(234, 134);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Adding";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(8, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnDeletedUser);
            this.metroTabPage3.Controls.Add(this.btnNewUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(234, 134);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Records";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btnDeletedUser
            // 
            this.btnDeletedUser.Location = new System.Drawing.Point(3, 32);
            this.btnDeletedUser.Name = "btnDeletedUser";
            this.btnDeletedUser.Size = new System.Drawing.Size(96, 23);
            this.btnDeletedUser.TabIndex = 8;
            this.btnDeletedUser.Text = "load Delete File";
            this.btnDeletedUser.UseSelectable = true;
            this.btnDeletedUser.Click += new System.EventHandler(this.btnDeletedUser_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(3, 3);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(96, 23);
            this.btnNewUser.TabIndex = 7;
            this.btnNewUser.Text = "load Request File";
            this.btnNewUser.UseSelectable = true;
            this.btnNewUser.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroTxtRank
            // 
            this.metroTxtRank.Lines = new string[0];
            this.metroTxtRank.Location = new System.Drawing.Point(117, 100);
            this.metroTxtRank.MaxLength = 32767;
            this.metroTxtRank.Name = "metroTxtRank";
            this.metroTxtRank.PasswordChar = '\0';
            this.metroTxtRank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtRank.SelectedText = "";
            this.metroTxtRank.Size = new System.Drawing.Size(107, 23);
            this.metroTxtRank.Style = MetroFramework.MetroColorStyle.White;
            this.metroTxtRank.TabIndex = 7;
            this.metroTxtRank.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTxtRank.UseSelectable = true;
            // 
            // metroTxtUserName
            // 
            this.metroTxtUserName.Lines = new string[0];
            this.metroTxtUserName.Location = new System.Drawing.Point(117, 58);
            this.metroTxtUserName.MaxLength = 32767;
            this.metroTxtUserName.Name = "metroTxtUserName";
            this.metroTxtUserName.PasswordChar = '\0';
            this.metroTxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtUserName.SelectedText = "";
            this.metroTxtUserName.Size = new System.Drawing.Size(107, 23);
            this.metroTxtUserName.Style = MetroFramework.MetroColorStyle.White;
            this.metroTxtUserName.TabIndex = 6;
            this.metroTxtUserName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTxtUserName.UseSelectable = true;
            // 
            // metroTxtID
            // 
            this.metroTxtID.Lines = new string[0];
            this.metroTxtID.Location = new System.Drawing.Point(117, 15);
            this.metroTxtID.MaxLength = 32767;
            this.metroTxtID.Name = "metroTxtID";
            this.metroTxtID.PasswordChar = '\0';
            this.metroTxtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtID.SelectedText = "";
            this.metroTxtID.Size = new System.Drawing.Size(107, 23);
            this.metroTxtID.Style = MetroFramework.MetroColorStyle.White;
            this.metroTxtID.TabIndex = 5;
            this.metroTxtID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTxtID.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Rank";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "UserName";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Login ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroDgvRequestLogin
            // 
            this.metroDgvRequestLogin.AllowUserToResizeRows = false;
            this.metroDgvRequestLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDgvRequestLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroDgvRequestLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroDgvRequestLogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroDgvRequestLogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroDgvRequestLogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroDgvRequestLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroDgvRequestLogin.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroDgvRequestLogin.EnableHeadersVisualStyles = false;
            this.metroDgvRequestLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroDgvRequestLogin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroDgvRequestLogin.Location = new System.Drawing.Point(3, 188);
            this.metroDgvRequestLogin.Name = "metroDgvRequestLogin";
            this.metroDgvRequestLogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroDgvRequestLogin.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroDgvRequestLogin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroDgvRequestLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroDgvRequestLogin.Size = new System.Drawing.Size(535, 193);
            this.metroDgvRequestLogin.TabIndex = 1;
            this.metroDgvRequestLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroDgvRequestLogin.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroDgvRequestLogin_RowEnter);
            // 
            // metroDgvLogin
            // 
            this.metroDgvLogin.AllowUserToResizeRows = false;
            this.metroDgvLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDgvLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroDgvLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroDgvLogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroDgvLogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroDgvLogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.metroDgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroDgvLogin.DefaultCellStyle = dataGridViewCellStyle23;
            this.metroDgvLogin.EnableHeadersVisualStyles = false;
            this.metroDgvLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroDgvLogin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroDgvLogin.Location = new System.Drawing.Point(3, 3);
            this.metroDgvLogin.Name = "metroDgvLogin";
            this.metroDgvLogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroDgvLogin.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.metroDgvLogin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroDgvLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroDgvLogin.Size = new System.Drawing.Size(535, 184);
            this.metroDgvLogin.TabIndex = 0;
            this.metroDgvLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroDgvLogin.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroDgvLogin_RowEnter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(135, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 68);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmLoginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLoginDetails";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmLoginDetails_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroDgvRequestLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroDgvLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid metroDgvLogin;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroDgvRequestLogin;
        private MetroFramework.Controls.MetroTextBox metroTxtRank;
        private MetroFramework.Controls.MetroTextBox metroTxtUserName;
        private MetroFramework.Controls.MetroTextBox metroTxtID;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnDeletedUser;
        private MetroFramework.Controls.MetroButton btnNewUser;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}