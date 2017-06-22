namespace ORMApplication
{
    partial class frmTeamListing
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
            this.lblPrject = new System.Windows.Forms.Label();
            this.dgvTeamListing = new System.Windows.Forms.DataGridView();
            this.TeamMappingPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamListing)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlProject
            // 
            this.ddlProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProject.FormattingEnabled = true;
            this.ddlProject.Location = new System.Drawing.Point(326, 39);
            this.ddlProject.Name = "ddlProject";
            this.ddlProject.Size = new System.Drawing.Size(157, 27);
            this.ddlProject.TabIndex = 4;
            this.ddlProject.SelectedIndexChanged += new System.EventHandler(this.ddlProject_SelectedIndexChanged);
            // 
            // lblPrject
            // 
            this.lblPrject.AutoSize = true;
            this.lblPrject.Location = new System.Drawing.Point(190, 43);
            this.lblPrject.Name = "lblPrject";
            this.lblPrject.Size = new System.Drawing.Size(94, 19);
            this.lblPrject.TabIndex = 5;
            this.lblPrject.Text = "Select Project";
            // 
            // dgvTeamListing
            // 
            this.dgvTeamListing.AllowUserToAddRows = false;
            this.dgvTeamListing.AllowUserToDeleteRows = false;
            this.dgvTeamListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTeamListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamMappingPK,
            this.ProjectName,
            this.ClientName,
            this.FName,
            this.ResourceType});
            this.dgvTeamListing.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTeamListing.Location = new System.Drawing.Point(12, 104);
            this.dgvTeamListing.Name = "dgvTeamListing";
            this.dgvTeamListing.ReadOnly = true;
            this.dgvTeamListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamListing.Size = new System.Drawing.Size(749, 275);
            this.dgvTeamListing.TabIndex = 6;
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
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "Employee Name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // ResourceType
            // 
            this.ResourceType.DataPropertyName = "ResourceType";
            this.ResourceType.HeaderText = "Resource Type";
            this.ResourceType.Name = "ResourceType";
            this.ResourceType.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.releaseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.releaseToolStripMenuItem.Text = "Release";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // frmTeamListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.dgvTeamListing);
            this.Controls.Add(this.ddlProject);
            this.Controls.Add(this.lblPrject);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTeamListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Listing";
            this.Load += new System.EventHandler(this.frmTeamListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamListing)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlProject;
        private System.Windows.Forms.Label lblPrject;
        private System.Windows.Forms.DataGridView dgvTeamListing;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamMappingPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
    }
}