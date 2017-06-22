namespace ORMApplication
{
    partial class frmLeaveConfig
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvLeaveConfig = new System.Windows.Forms.DataGridView();
            this.LeaveConfigPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.ddlProjectFK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeaveConfigPK = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.ddlLeaveType = new System.Windows.Forms.ComboBox();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ddlEmployeeFK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveConfig)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(142, 194);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 26);
            this.dtpEndDate.TabIndex = 3;
            // 
            // dgvLeaveConfig
            // 
            this.dgvLeaveConfig.AllowUserToAddRows = false;
            this.dgvLeaveConfig.AllowUserToDeleteRows = false;
            this.dgvLeaveConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveConfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvLeaveConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveConfigPK,
            this.LeaveStatus,
            this.EmployeeName,
            this.ProjectName,
            this.LeaveType});
            this.dgvLeaveConfig.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLeaveConfig.Location = new System.Drawing.Point(380, 34);
            this.dgvLeaveConfig.Name = "dgvLeaveConfig";
            this.dgvLeaveConfig.ReadOnly = true;
            this.dgvLeaveConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveConfig.Size = new System.Drawing.Size(504, 366);
            this.dgvLeaveConfig.TabIndex = 0;
            // 
            // LeaveConfigPK
            // 
            this.LeaveConfigPK.DataPropertyName = "LeaveConfigPK";
            this.LeaveConfigPK.HeaderText = "LeaveConfigPK";
            this.LeaveConfigPK.Name = "LeaveConfigPK";
            this.LeaveConfigPK.ReadOnly = true;
            this.LeaveConfigPK.Visible = false;
            // 
            // LeaveStatus
            // 
            this.LeaveStatus.DataPropertyName = "LeaveStatus";
            this.LeaveStatus.HeaderText = "Leave Status";
            this.LeaveStatus.Name = "LeaveStatus";
            this.LeaveStatus.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeID";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // LeaveType
            // 
            this.LeaveType.DataPropertyName = "LeaveType";
            this.LeaveType.HeaderText = "Leave Type";
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.ReadOnly = true;
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
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(142, 151);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 26);
            this.dtpStartDate.TabIndex = 2;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(6, 244);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(54, 19);
            this.lblClientEmail.TabIndex = 7;
            this.lblClientEmail.Text = "Reason";
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.lblEmployeeID);
            this.gbProject.Controls.Add(this.ddlProjectFK);
            this.gbProject.Controls.Add(this.label1);
            this.gbProject.Controls.Add(this.lblLeaveConfigPK);
            this.gbProject.Controls.Add(this.lblEmployeeName);
            this.gbProject.Controls.Add(this.txtReason);
            this.gbProject.Controls.Add(this.ddlLeaveType);
            this.gbProject.Controls.Add(this.dtpEndDate);
            this.gbProject.Controls.Add(this.dtpStartDate);
            this.gbProject.Controls.Add(this.lblClientEmail);
            this.gbProject.Controls.Add(this.lblLeaveType);
            this.gbProject.Controls.Add(this.lblEndDate);
            this.gbProject.Controls.Add(this.lblStartDate);
            this.gbProject.Controls.Add(this.btnClose);
            this.gbProject.Controls.Add(this.btnSubmit);
            this.gbProject.Location = new System.Drawing.Point(21, 12);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(347, 388);
            this.gbProject.TabIndex = 9;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Leave Configuration";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(147, 72);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 19);
            this.lblEmployeeID.TabIndex = 15;
            // 
            // ddlProjectFK
            // 
            this.ddlProjectFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProjectFK.FormattingEnabled = true;
            this.ddlProjectFK.Location = new System.Drawing.Point(142, 109);
            this.ddlProjectFK.Name = "ddlProjectFK";
            this.ddlProjectFK.Size = new System.Drawing.Size(157, 27);
            this.ddlProjectFK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project Name";
            // 
            // lblLeaveConfigPK
            // 
            this.lblLeaveConfigPK.AutoSize = true;
            this.lblLeaveConfigPK.Location = new System.Drawing.Point(109, 22);
            this.lblLeaveConfigPK.Name = "lblLeaveConfigPK";
            this.lblLeaveConfigPK.Size = new System.Drawing.Size(0, 19);
            this.lblLeaveConfigPK.TabIndex = 12;
            this.lblLeaveConfigPK.Visible = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 72);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(89, 19);
            this.lblEmployeeName.TabIndex = 10;
            this.lblEmployeeName.Text = "Employee ID";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(142, 241);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(157, 89);
            this.txtReason.TabIndex = 4;
            // 
            // ddlLeaveType
            // 
            this.ddlLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLeaveType.FormattingEnabled = true;
            this.ddlLeaveType.Location = new System.Drawing.Point(142, 25);
            this.ddlLeaveType.Name = "ddlLeaveType";
            this.ddlLeaveType.Size = new System.Drawing.Size(157, 27);
            this.ddlLeaveType.TabIndex = 0;
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.Location = new System.Drawing.Point(6, 28);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(80, 19);
            this.lblLeaveType.TabIndex = 4;
            this.lblLeaveType.Text = "Leave Type";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 196);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 19);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 151);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 19);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 348);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ddlEmployeeFK
            // 
            this.ddlEmployeeFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmployeeFK.FormattingEnabled = true;
            this.ddlEmployeeFK.Location = new System.Drawing.Point(408, 84);
            this.ddlEmployeeFK.Name = "ddlEmployeeFK";
            this.ddlEmployeeFK.Size = new System.Drawing.Size(157, 27);
            this.ddlEmployeeFK.TabIndex = 11;
            // 
            // frmLeaveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 412);
            this.Controls.Add(this.dgvLeaveConfig);
            this.Controls.Add(this.gbProject);
            this.Controls.Add(this.ddlEmployeeFK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLeaveConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Leave Configuration";
            this.Load += new System.EventHandler(this.frmLeaveConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveConfig)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgvLeaveConfig;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.ComboBox ddlLeaveType;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox ddlEmployeeFK;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblLeaveConfigPK;
        private System.Windows.Forms.ComboBox ddlProjectFK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveConfigPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
    }
}