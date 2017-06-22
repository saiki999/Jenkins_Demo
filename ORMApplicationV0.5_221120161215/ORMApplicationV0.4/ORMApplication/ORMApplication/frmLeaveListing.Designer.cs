namespace ORMApplication
{
    partial class frmLeaveListing
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
            this.ddlProject = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLeaveListing = new System.Windows.Forms.DataGridView();
            this.LeaveConfigPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrject = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveListing)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlProject
            // 
            this.ddlProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProject.FormattingEnabled = true;
            this.ddlProject.Location = new System.Drawing.Point(325, 25);
            this.ddlProject.Name = "ddlProject";
            this.ddlProject.Size = new System.Drawing.Size(157, 27);
            this.ddlProject.TabIndex = 7;
            this.ddlProject.SelectedIndexChanged += new System.EventHandler(this.ddlProject_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.acceptToolStripMenuItem.Text = "Accept";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.acceptToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // dgvLeaveListing
            // 
            this.dgvLeaveListing.AllowUserToAddRows = false;
            this.dgvLeaveListing.AllowUserToDeleteRows = false;
            this.dgvLeaveListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvLeaveListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveConfigPK,
            this.EmployeeID,
            this.ProjectName,
            this.LeaveType,
            this.LeaveSD,
            this.LeaveED,
            this.LeaveStatus});
            this.dgvLeaveListing.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLeaveListing.Location = new System.Drawing.Point(11, 90);
            this.dgvLeaveListing.Name = "dgvLeaveListing";
            this.dgvLeaveListing.ReadOnly = true;
            this.dgvLeaveListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveListing.Size = new System.Drawing.Size(749, 275);
            this.dgvLeaveListing.TabIndex = 9;
            // 
            // LeaveConfigPK
            // 
            this.LeaveConfigPK.DataPropertyName = "LeaveConfigPK";
            this.LeaveConfigPK.HeaderText = "LeaveConfigPK";
            this.LeaveConfigPK.Name = "LeaveConfigPK";
            this.LeaveConfigPK.ReadOnly = true;
            this.LeaveConfigPK.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Name";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
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
            // LeaveSD
            // 
            this.LeaveSD.DataPropertyName = "LeaveSD";
            this.LeaveSD.HeaderText = "Start Date";
            this.LeaveSD.Name = "LeaveSD";
            this.LeaveSD.ReadOnly = true;
            // 
            // LeaveED
            // 
            this.LeaveED.DataPropertyName = "LeaveED";
            this.LeaveED.HeaderText = "End Date";
            this.LeaveED.Name = "LeaveED";
            this.LeaveED.ReadOnly = true;
            // 
            // LeaveStatus
            // 
            this.LeaveStatus.DataPropertyName = "LeaveStatus";
            this.LeaveStatus.HeaderText = "Leave Status";
            this.LeaveStatus.Name = "LeaveStatus";
            this.LeaveStatus.ReadOnly = true;
            // 
            // lblPrject
            // 
            this.lblPrject.AutoSize = true;
            this.lblPrject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrject.Location = new System.Drawing.Point(189, 29);
            this.lblPrject.Name = "lblPrject";
            this.lblPrject.Size = new System.Drawing.Size(94, 19);
            this.lblPrject.TabIndex = 8;
            this.lblPrject.Text = "Select Project";
            // 
            // frmLeaveListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 391);
            this.Controls.Add(this.ddlProject);
            this.Controls.Add(this.dgvLeaveListing);
            this.Controls.Add(this.lblPrject);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLeaveListing";
            this.Text = "Leave Listing";
            this.Load += new System.EventHandler(this.frmLeaveListing_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvLeaveListing;
        private System.Windows.Forms.Label lblPrject;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveConfigPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveED;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveStatus;
    }
}