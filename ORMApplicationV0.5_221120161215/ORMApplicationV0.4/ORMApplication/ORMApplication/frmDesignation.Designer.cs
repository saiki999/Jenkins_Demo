namespace ORMApplication
{
    partial class frmDesignation
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbDesignation = new System.Windows.Forms.GroupBox();
            this.ddlDeptFK = new System.Windows.Forms.ComboBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDesgName = new System.Windows.Forms.TextBox();
            this.lblDesgName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.DesgPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDesignation.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            this.SuspendLayout();
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
            // gbDesignation
            // 
            this.gbDesignation.Controls.Add(this.ddlDeptFK);
            this.gbDesignation.Controls.Add(this.lblDeptName);
            this.gbDesignation.Controls.Add(this.btnClose);
            this.gbDesignation.Controls.Add(this.btnSubmit);
            this.gbDesignation.Controls.Add(this.txtDesgName);
            this.gbDesignation.Controls.Add(this.lblDesgName);
            this.gbDesignation.Location = new System.Drawing.Point(24, 44);
            this.gbDesignation.Name = "gbDesignation";
            this.gbDesignation.Size = new System.Drawing.Size(316, 253);
            this.gbDesignation.TabIndex = 1;
            this.gbDesignation.TabStop = false;
            this.gbDesignation.Text = "Designation Configuration";
            // 
            // ddlDeptFK
            // 
            this.ddlDeptFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDeptFK.FormattingEnabled = true;
            this.ddlDeptFK.Location = new System.Drawing.Point(142, 59);
            this.ddlDeptFK.Name = "ddlDeptFK";
            this.ddlDeptFK.Size = new System.Drawing.Size(157, 27);
            this.ddlDeptFK.TabIndex = 0;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(8, 59);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(121, 19);
            this.lblDeptName.TabIndex = 3;
            this.lblDeptName.Text = "Department Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDesgName
            // 
            this.txtDesgName.Location = new System.Drawing.Point(142, 121);
            this.txtDesgName.Name = "txtDesgName";
            this.txtDesgName.Size = new System.Drawing.Size(157, 26);
            this.txtDesgName.TabIndex = 1;
            // 
            // lblDesgName
            // 
            this.lblDesgName.AutoSize = true;
            this.lblDesgName.Location = new System.Drawing.Point(8, 124);
            this.lblDesgName.Name = "lblDesgName";
            this.lblDesgName.Size = new System.Drawing.Size(120, 19);
            this.lblDesgName.TabIndex = 0;
            this.lblDesgName.Text = "Designation Name";
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
            // dgvDesignation
            // 
            this.dgvDesignation.AllowUserToAddRows = false;
            this.dgvDesignation.AllowUserToDeleteRows = false;
            this.dgvDesignation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesignation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesgPK,
            this.DeptFK,
            this.DeptName,
            this.DesgName,
            this.CreatedOn});
            this.dgvDesignation.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDesignation.Location = new System.Drawing.Point(346, 25);
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.ReadOnly = true;
            this.dgvDesignation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesignation.Size = new System.Drawing.Size(426, 375);
            this.dgvDesignation.TabIndex = 0;
            // 
            // DesgPK
            // 
            this.DesgPK.DataPropertyName = "DesgPK";
            this.DesgPK.HeaderText = "DesgPK";
            this.DesgPK.Name = "DesgPK";
            this.DesgPK.ReadOnly = true;
            this.DesgPK.Visible = false;
            // 
            // DeptFK
            // 
            this.DeptFK.DataPropertyName = "DeptFK";
            this.DeptFK.HeaderText = "DeptFK";
            this.DeptFK.Name = "DeptFK";
            this.DeptFK.ReadOnly = true;
            this.DeptFK.Visible = false;
            // 
            // DeptName
            // 
            this.DeptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "Department Name";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // DesgName
            // 
            this.DesgName.DataPropertyName = "DesgName";
            this.DesgName.HeaderText = "DesgName";
            this.DesgName.Name = "DesgName";
            this.DesgName.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.HeaderText = "CreatedOn";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // frmDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.dgvDesignation);
            this.Controls.Add(this.gbDesignation);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designation ";
            this.Load += new System.EventHandler(this.frmDesignation_Load);
            this.gbDesignation.ResumeLayout(false);
            this.gbDesignation.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbDesignation;
        private System.Windows.Forms.TextBox txtDesgName;
        private System.Windows.Forms.Label lblDesgName;
        private System.Windows.Forms.ComboBox ddlDeptFK;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesgPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.Button btnClose;
    }
}