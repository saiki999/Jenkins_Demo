namespace ORMApplication
{
    partial class frmSkillSetConfig
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
            this.ddlSkillSetName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.ddlEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblSkillSetName = new System.Windows.Forms.Label();
            this.dgvSkillSetConfig = new System.Windows.Forms.DataGridView();
            this.SkillConfigPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillSetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSkillsetConfig = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillSetConfig)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbSkillsetConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlSkillSetName
            // 
            this.ddlSkillSetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSkillSetName.FormattingEnabled = true;
            this.ddlSkillSetName.Location = new System.Drawing.Point(143, 98);
            this.ddlSkillSetName.Name = "ddlSkillSetName";
            this.ddlSkillSetName.Size = new System.Drawing.Size(157, 27);
            this.ddlSkillSetName.TabIndex = 1;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 55);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(110, 19);
            this.lblEmployeeName.TabIndex = 10;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // ddlEmployeeName
            // 
            this.ddlEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmployeeName.FormattingEnabled = true;
            this.ddlEmployeeName.Location = new System.Drawing.Point(143, 47);
            this.ddlEmployeeName.Name = "ddlEmployeeName";
            this.ddlEmployeeName.Size = new System.Drawing.Size(157, 27);
            this.ddlEmployeeName.TabIndex = 0;
            // 
            // lblSkillSetName
            // 
            this.lblSkillSetName.AutoSize = true;
            this.lblSkillSetName.Location = new System.Drawing.Point(6, 106);
            this.lblSkillSetName.Name = "lblSkillSetName";
            this.lblSkillSetName.Size = new System.Drawing.Size(100, 19);
            this.lblSkillSetName.TabIndex = 4;
            this.lblSkillSetName.Text = "Skill Set Name";
            // 
            // dgvSkillSetConfig
            // 
            this.dgvSkillSetConfig.AllowUserToAddRows = false;
            this.dgvSkillSetConfig.AllowUserToDeleteRows = false;
            this.dgvSkillSetConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkillSetConfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSkillSetConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkillSetConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillConfigPK,
            this.EmployeeName,
            this.SkillSetName,
            this.CreatedOn});
            this.dgvSkillSetConfig.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSkillSetConfig.Location = new System.Drawing.Point(380, 22);
            this.dgvSkillSetConfig.Name = "dgvSkillSetConfig";
            this.dgvSkillSetConfig.ReadOnly = true;
            this.dgvSkillSetConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkillSetConfig.Size = new System.Drawing.Size(383, 378);
            this.dgvSkillSetConfig.TabIndex = 0;
            // 
            // SkillConfigPK
            // 
            this.SkillConfigPK.DataPropertyName = "SkillConfigPK";
            this.SkillConfigPK.HeaderText = "SkillConfigPK";
            this.SkillConfigPK.Name = "SkillConfigPK";
            this.SkillConfigPK.ReadOnly = true;
            this.SkillConfigPK.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "FName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // SkillSetName
            // 
            this.SkillSetName.DataPropertyName = "SkillSetName";
            this.SkillSetName.HeaderText = "SkillSet Name";
            this.SkillSetName.Name = "SkillSetName";
            this.SkillSetName.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.HeaderText = "Created On";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deactiveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // deactiveToolStripMenuItem
            // 
            this.deactiveToolStripMenuItem.Name = "deactiveToolStripMenuItem";
            this.deactiveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.deactiveToolStripMenuItem.Text = "Deactive";
            this.deactiveToolStripMenuItem.Click += new System.EventHandler(this.deactiveToolStripMenuItem_Click);
            // 
            // gbSkillsetConfig
            // 
            this.gbSkillsetConfig.Controls.Add(this.ddlSkillSetName);
            this.gbSkillsetConfig.Controls.Add(this.lblEmployeeName);
            this.gbSkillsetConfig.Controls.Add(this.ddlEmployeeName);
            this.gbSkillsetConfig.Controls.Add(this.lblSkillSetName);
            this.gbSkillsetConfig.Controls.Add(this.btnClose);
            this.gbSkillsetConfig.Controls.Add(this.btnSubmit);
            this.gbSkillsetConfig.Location = new System.Drawing.Point(12, 50);
            this.gbSkillsetConfig.Name = "gbSkillsetConfig";
            this.gbSkillsetConfig.Size = new System.Drawing.Size(347, 222);
            this.gbSkillsetConfig.TabIndex = 11;
            this.gbSkillsetConfig.TabStop = false;
            this.gbSkillsetConfig.Text = "Skillset Configuration";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(143, 157);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmSkillSetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.dgvSkillSetConfig);
            this.Controls.Add(this.gbSkillsetConfig);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSkillSetConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkillSet Configuration";
            this.Load += new System.EventHandler(this.frmSkillSetConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillSetConfig)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbSkillsetConfig.ResumeLayout(false);
            this.gbSkillsetConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlSkillSetName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.ComboBox ddlEmployeeName;
        private System.Windows.Forms.Label lblSkillSetName;
        private System.Windows.Forms.DataGridView dgvSkillSetConfig;
        private System.Windows.Forms.GroupBox gbSkillsetConfig;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillConfigPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillSetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
    }
}