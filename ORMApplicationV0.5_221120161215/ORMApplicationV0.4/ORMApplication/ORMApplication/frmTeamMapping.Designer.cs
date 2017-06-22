namespace ORMApplication
{
    partial class frmTeamMapping
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
            this.ddlEmployeeFK = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.ddlProjectFK = new System.Windows.Forms.ComboBox();
            this.gbTeamMapping = new System.Windows.Forms.GroupBox();
            this.lblTeamMappingPK = new System.Windows.Forms.Label();
            this.ddlResourceType = new System.Windows.Forms.ComboBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnClsoe = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvTeamMapping = new System.Windows.Forms.DataGridView();
            this.TeamMappingPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTeamMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMapping)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlEmployeeFK
            // 
            this.ddlEmployeeFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmployeeFK.FormattingEnabled = true;
            this.ddlEmployeeFK.Location = new System.Drawing.Point(142, 93);
            this.ddlEmployeeFK.Name = "ddlEmployeeFK";
            this.ddlEmployeeFK.Size = new System.Drawing.Size(157, 27);
            this.ddlEmployeeFK.TabIndex = 1;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 97);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(110, 19);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // ddlProjectFK
            // 
            this.ddlProjectFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProjectFK.FormattingEnabled = true;
            this.ddlProjectFK.Location = new System.Drawing.Point(142, 48);
            this.ddlProjectFK.Name = "ddlProjectFK";
            this.ddlProjectFK.Size = new System.Drawing.Size(157, 27);
            this.ddlProjectFK.TabIndex = 0;
            this.ddlProjectFK.SelectedIndexChanged += new System.EventHandler(this.ddlProjectFK_SelectedIndexChanged);
            // 
            // gbTeamMapping
            // 
            this.gbTeamMapping.Controls.Add(this.lblTeamMappingPK);
            this.gbTeamMapping.Controls.Add(this.ddlResourceType);
            this.gbTeamMapping.Controls.Add(this.lblResourceType);
            this.gbTeamMapping.Controls.Add(this.dtpEndDate);
            this.gbTeamMapping.Controls.Add(this.dtpStartDate);
            this.gbTeamMapping.Controls.Add(this.lblEndDate);
            this.gbTeamMapping.Controls.Add(this.lblStartDate);
            this.gbTeamMapping.Controls.Add(this.ddlEmployeeFK);
            this.gbTeamMapping.Controls.Add(this.lblEmployeeName);
            this.gbTeamMapping.Controls.Add(this.ddlProjectFK);
            this.gbTeamMapping.Controls.Add(this.lblProjectName);
            this.gbTeamMapping.Controls.Add(this.btnClsoe);
            this.gbTeamMapping.Controls.Add(this.btnSubmit);
            this.gbTeamMapping.Location = new System.Drawing.Point(21, 12);
            this.gbTeamMapping.Name = "gbTeamMapping";
            this.gbTeamMapping.Size = new System.Drawing.Size(347, 388);
            this.gbTeamMapping.TabIndex = 7;
            this.gbTeamMapping.TabStop = false;
            this.gbTeamMapping.Text = "Team Mapping";
            // 
            // lblTeamMappingPK
            // 
            this.lblTeamMappingPK.AutoSize = true;
            this.lblTeamMappingPK.Location = new System.Drawing.Point(104, 22);
            this.lblTeamMappingPK.Name = "lblTeamMappingPK";
            this.lblTeamMappingPK.Size = new System.Drawing.Size(0, 19);
            this.lblTeamMappingPK.TabIndex = 16;
            this.lblTeamMappingPK.Visible = false;
            // 
            // ddlResourceType
            // 
            this.ddlResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlResourceType.FormattingEnabled = true;
            this.ddlResourceType.Items.AddRange(new object[] {
            "Shared",
            "Dedicated"});
            this.ddlResourceType.Location = new System.Drawing.Point(142, 138);
            this.ddlResourceType.Name = "ddlResourceType";
            this.ddlResourceType.Size = new System.Drawing.Size(157, 27);
            this.ddlResourceType.TabIndex = 2;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(6, 142);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(100, 19);
            this.lblResourceType.TabIndex = 15;
            this.lblResourceType.Text = "Resource Type";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(142, 228);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 26);
            this.dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(142, 185);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 26);
            this.dtpStartDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 230);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 19);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 185);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 19);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(6, 52);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(94, 19);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            // 
            // btnClsoe
            // 
            this.btnClsoe.Location = new System.Drawing.Point(224, 278);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(75, 34);
            this.btnClsoe.TabIndex = 6;
            this.btnClsoe.Text = "Close";
            this.btnClsoe.UseVisualStyleBackColor = true;
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 278);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvTeamMapping
            // 
            this.dgvTeamMapping.AllowUserToAddRows = false;
            this.dgvTeamMapping.AllowUserToDeleteRows = false;
            this.dgvTeamMapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamMapping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTeamMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamMappingPK,
            this.ProjectName,
            this.EmployeeID,
            this.EmployeeSD,
            this.EmployeeED});
            this.dgvTeamMapping.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTeamMapping.Location = new System.Drawing.Point(380, 60);
            this.dgvTeamMapping.Name = "dgvTeamMapping";
            this.dgvTeamMapping.ReadOnly = true;
            this.dgvTeamMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamMapping.Size = new System.Drawing.Size(383, 340);
            this.dgvTeamMapping.TabIndex = 0;
            // 
            // TeamMappingPK
            // 
            this.TeamMappingPK.DataPropertyName = "TeamMappingPK";
            this.TeamMappingPK.HeaderText = "TeamMappingPK";
            this.TeamMappingPK.Name = "TeamMappingPK";
            this.TeamMappingPK.ReadOnly = true;
            this.TeamMappingPK.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee Name";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeSD
            // 
            this.EmployeeSD.DataPropertyName = "EmployeeSD";
            this.EmployeeSD.HeaderText = "Start Date";
            this.EmployeeSD.Name = "EmployeeSD";
            this.EmployeeSD.ReadOnly = true;
            // 
            // EmployeeED
            // 
            this.EmployeeED.DataPropertyName = "EmployeeED";
            this.EmployeeED.HeaderText = "End Date";
            this.EmployeeED.Name = "EmployeeED";
            this.EmployeeED.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deactiveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deactiveToolStripMenuItem
            // 
            this.deactiveToolStripMenuItem.Name = "deactiveToolStripMenuItem";
            this.deactiveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.deactiveToolStripMenuItem.Text = "Deactive";
            this.deactiveToolStripMenuItem.Click += new System.EventHandler(this.deactiveToolStripMenuItem_Click);
            // 
            // frmTeamMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.gbTeamMapping);
            this.Controls.Add(this.dgvTeamMapping);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTeamMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Mapping";
            this.Load += new System.EventHandler(this.frmTeamMapping_Load);
            this.gbTeamMapping.ResumeLayout(false);
            this.gbTeamMapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMapping)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlEmployeeFK;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.ComboBox ddlProjectFK;
        private System.Windows.Forms.GroupBox gbTeamMapping;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvTeamMapping;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox ddlResourceType;
        private System.Windows.Forms.Label lblResourceType;
        private System.Windows.Forms.Label lblTeamMappingPK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.Button btnClsoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamMappingPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeED;
    }
}