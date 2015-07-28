namespace Practical_6___SD___Database_Access
{
    partial class XYZ_Form
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
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdNum = new System.Windows.Forms.TextBox();
            this.txtProdDes = new System.Windows.Forms.TextBox();
            this.txtProdCost = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.productViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Location = new System.Drawing.Point(107, 55);
            this.cmbProdCat.MaxDropDownItems = 10;
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(121, 21);
            this.cmbProdCat.TabIndex = 0;
            this.cmbProdCat.SelectedIndexChanged += new System.EventHandler(this.cmbProdCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Cost";
            // 
            // txtProdNum
            // 
            this.txtProdNum.Location = new System.Drawing.Point(128, 104);
            this.txtProdNum.Name = "txtProdNum";
            this.txtProdNum.Size = new System.Drawing.Size(100, 20);
            this.txtProdNum.TabIndex = 5;
            // 
            // txtProdDes
            // 
            this.txtProdDes.Location = new System.Drawing.Point(128, 153);
            this.txtProdDes.Name = "txtProdDes";
            this.txtProdDes.Size = new System.Drawing.Size(100, 20);
            this.txtProdDes.TabIndex = 6;
            // 
            // txtProdCost
            // 
            this.txtProdCost.Location = new System.Drawing.Point(128, 203);
            this.txtProdCost.Name = "txtProdCost";
            this.txtProdCost.Size = new System.Drawing.Size(100, 20);
            this.txtProdCost.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filleToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filleToolStripMenuItem
            // 
            this.filleToolStripMenuItem.Name = "filleToolStripMenuItem";
            this.filleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filleToolStripMenuItem.Text = "Fille";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vProducts});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.formsToolStripMenuItem.Text = "View";
            // 
            // vProducts
            // 
            this.vProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productViewToolStripMenuItem,
            this.toolStripMenuItem1});
            this.vProducts.Name = "vProducts";
            this.vProducts.Size = new System.Drawing.Size(152, 22);
            this.vProducts.Text = "ViewProducts";
            // 
            // productViewToolStripMenuItem
            // 
            this.productViewToolStripMenuItem.Name = "productViewToolStripMenuItem";
            this.productViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productViewToolStripMenuItem.Text = "ProductView";
            this.productViewToolStripMenuItem.Click += new System.EventHandler(this.productViewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "AllProducts";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // XYZ_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtProdCost);
            this.Controls.Add(this.txtProdDes);
            this.Controls.Add(this.txtProdNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProdCat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XYZ_Form";
            this.Text = "XYZCompany";
            this.Load += new System.EventHandler(this.XYZ_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProdCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdNum;
        private System.Windows.Forms.TextBox txtProdDes;
        private System.Windows.Forms.TextBox txtProdCost;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vProducts;
        private System.Windows.Forms.ToolStripMenuItem productViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

