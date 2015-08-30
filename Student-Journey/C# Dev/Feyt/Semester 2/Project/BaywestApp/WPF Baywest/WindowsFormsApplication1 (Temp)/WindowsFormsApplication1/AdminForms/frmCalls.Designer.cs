namespace WindowsFormsApplication1
{
    partial class frmCalls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalls));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpTxtBox = new System.Windows.Forms.GroupBox();
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCallType = new System.Windows.Forms.TextBox();
            this.txtCallID = new System.Windows.Forms.TextBox();
            this.dgvCalls = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grpTxtBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpTxtBox
            // 
            this.grpTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.grpTxtBox.Controls.Add(this.txtProblemDescription);
            this.grpTxtBox.Controls.Add(this.label3);
            this.grpTxtBox.Controls.Add(this.label2);
            this.grpTxtBox.Controls.Add(this.label1);
            this.grpTxtBox.Controls.Add(this.txtCallType);
            this.grpTxtBox.Controls.Add(this.txtCallID);
            this.grpTxtBox.Location = new System.Drawing.Point(12, 12);
            this.grpTxtBox.Name = "grpTxtBox";
            this.grpTxtBox.Size = new System.Drawing.Size(228, 239);
            this.grpTxtBox.TabIndex = 11;
            this.grpTxtBox.TabStop = false;
            this.grpTxtBox.Text = "TextBox";
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Location = new System.Drawing.Point(98, 93);
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(100, 20);
            this.txtProblemDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Problem Descrip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Call Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Call ID";
            // 
            // txtCallType
            // 
            this.txtCallType.Location = new System.Drawing.Point(98, 52);
            this.txtCallType.Name = "txtCallType";
            this.txtCallType.Size = new System.Drawing.Size(100, 20);
            this.txtCallType.TabIndex = 1;
            // 
            // txtCallID
            // 
            this.txtCallID.Location = new System.Drawing.Point(98, 22);
            this.txtCallID.Name = "txtCallID";
            this.txtCallID.Size = new System.Drawing.Size(100, 20);
            this.txtCallID.TabIndex = 0;
            // 
            // dgvCalls
            // 
            this.dgvCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalls.Location = new System.Drawing.Point(383, 12);
            this.dgvCalls.Name = "dgvCalls";
            this.dgvCalls.Size = new System.Drawing.Size(462, 440);
            this.dgvCalls.TabIndex = 12;
            this.dgvCalls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalls_CellClick);
            // 
            // frmCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Baywest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTxtBox);
            this.Controls.Add(this.dgvCalls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalls";
            this.Text = "Calls";
            this.Load += new System.EventHandler(this.frmCalls_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpTxtBox.ResumeLayout(false);
            this.grpTxtBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpTxtBox;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCallType;
        private System.Windows.Forms.TextBox txtCallID;
        private System.Windows.Forms.DataGridView dgvCalls;
    }
}