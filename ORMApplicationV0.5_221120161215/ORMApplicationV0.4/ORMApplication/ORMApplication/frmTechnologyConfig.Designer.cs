namespace ORMApplication
{
    partial class frmTechnologyConfig
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
            this.ddlRoomFK = new System.Windows.Forms.ComboBox();
            this.lblRoomFK = new System.Windows.Forms.Label();
            this.dgvTechnology = new System.Windows.Forms.DataGridView();
            this.TechRoomPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbTechConfig = new System.Windows.Forms.GroupBox();
            this.ddlTechFK = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnology)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbTechConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlRoomFK
            // 
            this.ddlRoomFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRoomFK.FormattingEnabled = true;
            this.ddlRoomFK.Location = new System.Drawing.Point(142, 59);
            this.ddlRoomFK.Name = "ddlRoomFK";
            this.ddlRoomFK.Size = new System.Drawing.Size(157, 27);
            this.ddlRoomFK.TabIndex = 0;
            this.ddlRoomFK.SelectedIndexChanged += new System.EventHandler(this.ddlRoomFK_SelectedIndexChanged);
            // 
            // lblRoomFK
            // 
            this.lblRoomFK.AutoSize = true;
            this.lblRoomFK.Location = new System.Drawing.Point(8, 59);
            this.lblRoomFK.Name = "lblRoomFK";
            this.lblRoomFK.Size = new System.Drawing.Size(87, 19);
            this.lblRoomFK.TabIndex = 3;
            this.lblRoomFK.Text = "Room Name";
            // 
            // dgvTechnology
            // 
            this.dgvTechnology.AllowUserToAddRows = false;
            this.dgvTechnology.AllowUserToDeleteRows = false;
            this.dgvTechnology.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnology.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTechnology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnology.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TechRoomPK,
            this.RoomFK,
            this.RoomName,
            this.TechFK,
            this.TechnologyName,
            this.CreatedOn});
            this.dgvTechnology.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTechnology.Location = new System.Drawing.Point(377, 54);
            this.dgvTechnology.Name = "dgvTechnology";
            this.dgvTechnology.ReadOnly = true;
            this.dgvTechnology.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnology.Size = new System.Drawing.Size(383, 315);
            this.dgvTechnology.TabIndex = 0;
            // 
            // TechRoomPK
            // 
            this.TechRoomPK.DataPropertyName = "TechRoomPK";
            this.TechRoomPK.HeaderText = "TechRoomPK";
            this.TechRoomPK.Name = "TechRoomPK";
            this.TechRoomPK.ReadOnly = true;
            this.TechRoomPK.Visible = false;
            // 
            // RoomFK
            // 
            this.RoomFK.DataPropertyName = "RoomFK";
            this.RoomFK.HeaderText = "RoomFK";
            this.RoomFK.Name = "RoomFK";
            this.RoomFK.ReadOnly = true;
            this.RoomFK.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // TechFK
            // 
            this.TechFK.DataPropertyName = "TechFK";
            this.TechFK.HeaderText = "TechFK";
            this.TechFK.Name = "TechFK";
            this.TechFK.ReadOnly = true;
            this.TechFK.Visible = false;
            // 
            // TechnologyName
            // 
            this.TechnologyName.DataPropertyName = "TechnologyName";
            this.TechnologyName.HeaderText = "TechnologyName";
            this.TechnologyName.Name = "TechnologyName";
            this.TechnologyName.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.HeaderText = "CreatedOn";
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbTechConfig
            // 
            this.gbTechConfig.Controls.Add(this.ddlTechFK);
            this.gbTechConfig.Controls.Add(this.ddlRoomFK);
            this.gbTechConfig.Controls.Add(this.lblRoomFK);
            this.gbTechConfig.Controls.Add(this.button1);
            this.gbTechConfig.Controls.Add(this.btnSubmit);
            this.gbTechConfig.Controls.Add(this.lblTechnologyName);
            this.gbTechConfig.Location = new System.Drawing.Point(24, 44);
            this.gbTechConfig.Name = "gbTechConfig";
            this.gbTechConfig.Size = new System.Drawing.Size(316, 253);
            this.gbTechConfig.TabIndex = 3;
            this.gbTechConfig.TabStop = false;
            this.gbTechConfig.Text = "Room Configuration";
            // 
            // ddlTechFK
            // 
            this.ddlTechFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTechFK.FormattingEnabled = true;
            this.ddlTechFK.Location = new System.Drawing.Point(142, 121);
            this.ddlTechFK.Name = "ddlTechFK";
            this.ddlTechFK.Size = new System.Drawing.Size(157, 27);
            this.ddlTechFK.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTechnologyName
            // 
            this.lblTechnologyName.AutoSize = true;
            this.lblTechnologyName.Location = new System.Drawing.Point(8, 124);
            this.lblTechnologyName.Name = "lblTechnologyName";
            this.lblTechnologyName.Size = new System.Drawing.Size(119, 19);
            this.lblTechnologyName.TabIndex = 0;
            this.lblTechnologyName.Text = "Technology Name";
            // 
            // frmTechnologyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.dgvTechnology);
            this.Controls.Add(this.gbTechConfig);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTechnologyConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Configuration";
            this.Load += new System.EventHandler(this.frmTechnologyConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnology)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbTechConfig.ResumeLayout(false);
            this.gbTechConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlRoomFK;
        private System.Windows.Forms.Label lblRoomFK;
        private System.Windows.Forms.DataGridView dgvTechnology;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbTechConfig;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.ComboBox ddlTechFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechRoomPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}