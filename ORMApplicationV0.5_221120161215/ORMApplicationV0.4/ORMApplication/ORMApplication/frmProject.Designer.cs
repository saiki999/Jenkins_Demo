namespace ORMApplication
{
    partial class frmProject
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.ddlManagerFK = new System.Windows.Forms.ComboBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.txtClientPhNo = new System.Windows.Forms.MaskedTextBox();
            this.lblProjectPK = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtClientPhNo1 = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblProjectMgr = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClientPhNo = new System.Windows.Forms.Label();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.ProjectPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectMgrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(142, 25);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(157, 26);
            this.txtProjectName.TabIndex = 0;
            // 
            // ddlManagerFK
            // 
            this.ddlManagerFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlManagerFK.FormattingEnabled = true;
            this.ddlManagerFK.Location = new System.Drawing.Point(142, 156);
            this.ddlManagerFK.Name = "ddlManagerFK";
            this.ddlManagerFK.Size = new System.Drawing.Size(157, 27);
            this.ddlManagerFK.TabIndex = 3;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(6, 28);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(94, 19);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "Project Name";
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.txtClientPhNo);
            this.gbProject.Controls.Add(this.lblProjectPK);
            this.gbProject.Controls.Add(this.dtpEndDate);
            this.gbProject.Controls.Add(this.dataGridView1);
            this.gbProject.Controls.Add(this.dtpStartDate);
            this.gbProject.Controls.Add(this.txtClientPhNo1);
            this.gbProject.Controls.Add(this.txtClientEmail);
            this.gbProject.Controls.Add(this.lblClientEmail);
            this.gbProject.Controls.Add(this.txtProjectName);
            this.gbProject.Controls.Add(this.lblProjectName);
            this.gbProject.Controls.Add(this.ddlManagerFK);
            this.gbProject.Controls.Add(this.lblEndDate);
            this.gbProject.Controls.Add(this.lblStartDate);
            this.gbProject.Controls.Add(this.btnClose);
            this.gbProject.Controls.Add(this.btnSubmit);
            this.gbProject.Controls.Add(this.lblProjectMgr);
            this.gbProject.Controls.Add(this.txtClientName);
            this.gbProject.Controls.Add(this.lblEmail);
            this.gbProject.Controls.Add(this.lblClientPhNo);
            this.gbProject.Location = new System.Drawing.Point(21, 12);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(347, 388);
            this.gbProject.TabIndex = 7;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Project Profile Add";
            // 
            // txtClientPhNo
            // 
            this.txtClientPhNo.Location = new System.Drawing.Point(142, 249);
            this.txtClientPhNo.Mask = "(999) 000-0000";
            this.txtClientPhNo.Name = "txtClientPhNo";
            this.txtClientPhNo.Size = new System.Drawing.Size(157, 26);
            this.txtClientPhNo.TabIndex = 5;
            // 
            // lblProjectPK
            // 
            this.lblProjectPK.AutoSize = true;
            this.lblProjectPK.Location = new System.Drawing.Point(110, 14);
            this.lblProjectPK.Name = "lblProjectPK";
            this.lblProjectPK.Size = new System.Drawing.Size(0, 19);
            this.lblProjectPK.TabIndex = 8;
            this.lblProjectPK.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(142, 111);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 26);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(359, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 378);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProjectPK";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProjectPK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProjectSD";
            this.dataGridViewTextBoxColumn3.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProjectED";
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProjectMgrName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Manager Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClientName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Client Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(142, 68);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 26);
            this.dtpStartDate.TabIndex = 1;
            // 
            // txtClientPhNo1
            // 
            this.txtClientPhNo1.Location = new System.Drawing.Point(142, 249);
            this.txtClientPhNo1.MaxLength = 11;
            this.txtClientPhNo1.Name = "txtClientPhNo1";
            this.txtClientPhNo1.Size = new System.Drawing.Size(157, 26);
            this.txtClientPhNo1.TabIndex = 5;
            this.txtClientPhNo1.Visible = false;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(142, 292);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(157, 26);
            this.txtClientEmail.TabIndex = 6;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(6, 296);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(81, 19);
            this.lblClientEmail.TabIndex = 7;
            this.lblClientEmail.Text = "Client Email";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 113);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 19);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 68);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 19);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 345);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblProjectMgr
            // 
            this.lblProjectMgr.AutoSize = true;
            this.lblProjectMgr.Location = new System.Drawing.Point(6, 160);
            this.lblProjectMgr.Name = "lblProjectMgr";
            this.lblProjectMgr.Size = new System.Drawing.Size(104, 19);
            this.lblProjectMgr.TabIndex = 0;
            this.lblProjectMgr.Text = "Manager Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(142, 201);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(157, 26);
            this.txtClientName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Client Name";
            // 
            // lblClientPhNo
            // 
            this.lblClientPhNo.AutoSize = true;
            this.lblClientPhNo.Location = new System.Drawing.Point(6, 253);
            this.lblClientPhNo.Name = "lblClientPhNo";
            this.lblClientPhNo.Size = new System.Drawing.Size(88, 19);
            this.lblClientPhNo.TabIndex = 0;
            this.lblClientPhNo.Text = "Client Ph No";
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectPK,
            this.ProjectName,
            this.ProjectSD,
            this.ProjectED,
            this.ProjectMgrName,
            this.ClientName});
            this.dgvProject.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProject.Location = new System.Drawing.Point(380, 22);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(792, 378);
            this.dgvProject.TabIndex = 0;
            // 
            // ProjectPK
            // 
            this.ProjectPK.DataPropertyName = "ProjectPK";
            this.ProjectPK.HeaderText = "ProjectPK";
            this.ProjectPK.Name = "ProjectPK";
            this.ProjectPK.ReadOnly = true;
            this.ProjectPK.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // ProjectSD
            // 
            this.ProjectSD.DataPropertyName = "ProjectSD";
            this.ProjectSD.HeaderText = "StartDate";
            this.ProjectSD.Name = "ProjectSD";
            this.ProjectSD.ReadOnly = true;
            // 
            // ProjectED
            // 
            this.ProjectED.DataPropertyName = "ProjectED";
            this.ProjectED.HeaderText = "End Date";
            this.ProjectED.Name = "ProjectED";
            this.ProjectED.ReadOnly = true;
            // 
            // ProjectMgrName
            // 
            this.ProjectMgrName.DataPropertyName = "ProjectMgrName";
            this.ProjectMgrName.HeaderText = "Manager Name";
            this.ProjectMgrName.Name = "ProjectMgrName";
            this.ProjectMgrName.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
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
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 412);
            this.Controls.Add(this.gbProject);
            this.Controls.Add(this.dgvProject);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Master";
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.ComboBox ddlManagerFK;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblProjectMgr;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClientPhNo;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtClientPhNo1;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblProjectPK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectMgrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.MaskedTextBox txtClientPhNo;
    }
}