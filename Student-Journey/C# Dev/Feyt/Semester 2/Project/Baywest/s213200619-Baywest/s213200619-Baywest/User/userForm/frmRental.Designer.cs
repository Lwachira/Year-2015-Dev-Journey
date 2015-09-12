namespace s213200619_Baywest.User.userForm
{
    partial class frmRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroRentalStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroRentalEndDate = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.metrodgvRental = new MetroFramework.Controls.MetroGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnShop = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnRegister = new MetroFramework.Controls.MetroTile();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.metrodgvRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroRentalStartDate
            // 
            this.metroRentalStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroRentalStartDate.CalendarTrailingForeColor = System.Drawing.Color.DarkRed;
            this.metroRentalStartDate.Enabled = false;
            this.metroRentalStartDate.Location = new System.Drawing.Point(6, 35);
            this.metroRentalStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroRentalStartDate.Name = "metroRentalStartDate";
            this.metroRentalStartDate.Size = new System.Drawing.Size(200, 29);
            this.metroRentalStartDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroRentalStartDate.TabIndex = 20;
            // 
            // metroRentalEndDate
            // 
            this.metroRentalEndDate.Enabled = false;
            this.metroRentalEndDate.Location = new System.Drawing.Point(3, 96);
            this.metroRentalEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroRentalEndDate.Name = "metroRentalEndDate";
            this.metroRentalEndDate.Size = new System.Drawing.Size(200, 29);
            this.metroRentalEndDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroRentalEndDate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "RentalEndDate:";
            // 
            // metrodgvRental
            // 
            this.metrodgvRental.AllowUserToAddRows = false;
            this.metrodgvRental.AllowUserToDeleteRows = false;
            this.metrodgvRental.AllowUserToResizeRows = false;
            this.metrodgvRental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrodgvRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metrodgvRental.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metrodgvRental.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrodgvRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metrodgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metrodgvRental.DefaultCellStyle = dataGridViewCellStyle2;
            this.metrodgvRental.EnableHeadersVisualStyles = false;
            this.metrodgvRental.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metrodgvRental.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrodgvRental.Location = new System.Drawing.Point(3, 3);
            this.metrodgvRental.Name = "metrodgvRental";
            this.metrodgvRental.ReadOnly = true;
            this.metrodgvRental.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrodgvRental.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metrodgvRental.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metrodgvRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metrodgvRental.Size = new System.Drawing.Size(533, 150);
            this.metrodgvRental.Style = MetroFramework.MetroColorStyle.Lime;
            this.metrodgvRental.TabIndex = 2;
            this.metrodgvRental.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.metrodgvRental_RowEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RentalStartDate:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroTabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.metroRentalStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.metroRentalEndDate);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroProgressBar1);
            this.splitContainer1.Panel2.Controls.Add(this.metrodgvRental);
            this.splitContainer1.Size = new System.Drawing.Size(814, 354);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 21;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 152);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(262, 199);
            this.metroTabControl1.TabIndex = 21;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnShop);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(254, 157);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Navigation";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnShop
            // 
            this.btnShop.ActiveControl = null;
            this.btnShop.Location = new System.Drawing.Point(77, 19);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(92, 75);
            this.btnShop.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnShop.UseSelectable = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnRegister);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(254, 157);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Request";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveControl = null;
            this.btnRegister.Location = new System.Drawing.Point(63, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 57);
            this.btnRegister.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(436, 328);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.TabIndex = 22;
            this.metroProgressBar1.Value = 40;
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRental";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.frmRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metrodgvRental)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid metrodgvRental;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime metroRentalEndDate;
        private MetroFramework.Controls.MetroDateTime metroRentalStartDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile btnShop;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile btnRegister;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}