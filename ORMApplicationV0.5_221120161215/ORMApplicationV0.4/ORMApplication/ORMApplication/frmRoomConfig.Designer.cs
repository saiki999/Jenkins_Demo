namespace ORMApplication
{
    partial class frmRoomConfig
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
            this.dgvRoomConfig = new System.Windows.Forms.DataGridView();
            this.RoomConfigPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddlRoomName = new System.Windows.Forms.ComboBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.ddlProjectFK = new System.Windows.Forms.ComboBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbTeamMapping = new System.Windows.Forms.GroupBox();
            this.lblRoomConfigPK = new System.Windows.Forms.Label();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            this.ddlTechnologyName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomConfig)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbTeamMapping.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoomConfig
            // 
            this.dgvRoomConfig.AllowUserToAddRows = false;
            this.dgvRoomConfig.AllowUserToDeleteRows = false;
            this.dgvRoomConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomConfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvRoomConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomConfigPK,
            this.ProjectName,
            this.RoomName,
            this.TechnologyName});
            this.dgvRoomConfig.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRoomConfig.Location = new System.Drawing.Point(380, 22);
            this.dgvRoomConfig.Name = "dgvRoomConfig";
            this.dgvRoomConfig.ReadOnly = true;
            this.dgvRoomConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomConfig.Size = new System.Drawing.Size(383, 378);
            this.dgvRoomConfig.TabIndex = 0;
            // 
            // RoomConfigPK
            // 
            this.RoomConfigPK.DataPropertyName = "RoomConfigPK";
            this.RoomConfigPK.HeaderText = "RoomConfigPK";
            this.RoomConfigPK.Name = "RoomConfigPK";
            this.RoomConfigPK.ReadOnly = true;
            this.RoomConfigPK.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "RoomName";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // TechnologyName
            // 
            this.TechnologyName.DataPropertyName = "TechnologyName";
            this.TechnologyName.HeaderText = "TechnologyName";
            this.TechnologyName.Name = "TechnologyName";
            this.TechnologyName.ReadOnly = true;
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
            // ddlRoomName
            // 
            this.ddlRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRoomName.FormattingEnabled = true;
            this.ddlRoomName.Location = new System.Drawing.Point(142, 93);
            this.ddlRoomName.Name = "ddlRoomName";
            this.ddlRoomName.Size = new System.Drawing.Size(157, 27);
            this.ddlRoomName.TabIndex = 1;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(6, 97);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(87, 19);
            this.lblRoomName.TabIndex = 3;
            this.lblRoomName.Text = "Room Name";
            // 
            // ddlProjectFK
            // 
            this.ddlProjectFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProjectFK.FormattingEnabled = true;
            this.ddlProjectFK.Location = new System.Drawing.Point(142, 48);
            this.ddlProjectFK.Name = "ddlProjectFK";
            this.ddlProjectFK.Size = new System.Drawing.Size(157, 27);
            this.ddlProjectFK.TabIndex = 0;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbTeamMapping
            // 
            this.gbTeamMapping.Controls.Add(this.lblRoomConfigPK);
            this.gbTeamMapping.Controls.Add(this.lblTechnologyName);
            this.gbTeamMapping.Controls.Add(this.ddlTechnologyName);
            this.gbTeamMapping.Controls.Add(this.ddlRoomName);
            this.gbTeamMapping.Controls.Add(this.lblRoomName);
            this.gbTeamMapping.Controls.Add(this.ddlProjectFK);
            this.gbTeamMapping.Controls.Add(this.lblProjectName);
            this.gbTeamMapping.Controls.Add(this.btnClose);
            this.gbTeamMapping.Controls.Add(this.btnSubmit);
            this.gbTeamMapping.Location = new System.Drawing.Point(21, 12);
            this.gbTeamMapping.Name = "gbTeamMapping";
            this.gbTeamMapping.Size = new System.Drawing.Size(332, 243);
            this.gbTeamMapping.TabIndex = 0;
            this.gbTeamMapping.TabStop = false;
            this.gbTeamMapping.Text = "Room Configuration";
            // 
            // lblRoomConfigPK
            // 
            this.lblRoomConfigPK.AutoSize = true;
            this.lblRoomConfigPK.Location = new System.Drawing.Point(145, 21);
            this.lblRoomConfigPK.Name = "lblRoomConfigPK";
            this.lblRoomConfigPK.Size = new System.Drawing.Size(0, 19);
            this.lblRoomConfigPK.TabIndex = 9;
            // 
            // lblTechnologyName
            // 
            this.lblTechnologyName.AutoSize = true;
            this.lblTechnologyName.Location = new System.Drawing.Point(9, 143);
            this.lblTechnologyName.Name = "lblTechnologyName";
            this.lblTechnologyName.Size = new System.Drawing.Size(119, 19);
            this.lblTechnologyName.TabIndex = 8;
            this.lblTechnologyName.Text = "Technology Name";
            // 
            // ddlTechnologyName
            // 
            this.ddlTechnologyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTechnologyName.FormattingEnabled = true;
            this.ddlTechnologyName.Location = new System.Drawing.Point(142, 140);
            this.ddlTechnologyName.Name = "ddlTechnologyName";
            this.ddlTechnologyName.Size = new System.Drawing.Size(157, 27);
            this.ddlTechnologyName.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRoomConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.dgvRoomConfig);
            this.Controls.Add(this.gbTeamMapping);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRoomConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Configuration";
            this.Load += new System.EventHandler(this.frmRoomConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomConfig)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbTeamMapping.ResumeLayout(false);
            this.gbTeamMapping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomConfig;
        private System.Windows.Forms.ComboBox ddlRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.ComboBox ddlProjectFK;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbTeamMapping;
        private System.Windows.Forms.ComboBox ddlTechnologyName;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.Label lblRoomConfigPK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomConfigPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyName;
        private System.Windows.Forms.Button btnClose;
    }
}