namespace ORMApplication
{
    partial class frmTechnology
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
            this.gbTechnology = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTechnologyName = new System.Windows.Forms.TextBox();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            this.dgvTechnology = new System.Windows.Forms.DataGridView();
            this.TechnologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTechnology.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnology)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(145, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbTechnology
            // 
            this.gbTechnology.Controls.Add(this.btnClose);
            this.gbTechnology.Controls.Add(this.btnSubmit);
            this.gbTechnology.Controls.Add(this.txtTechnologyName);
            this.gbTechnology.Controls.Add(this.lblTechnologyName);
            this.gbTechnology.Location = new System.Drawing.Point(24, 44);
            this.gbTechnology.Name = "gbTechnology";
            this.gbTechnology.Size = new System.Drawing.Size(316, 180);
            this.gbTechnology.TabIndex = 4;
            this.gbTechnology.TabStop = false;
            this.gbTechnology.Text = "Technology Add";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTechnologyName
            // 
            this.txtTechnologyName.Location = new System.Drawing.Point(145, 56);
            this.txtTechnologyName.Name = "txtTechnologyName";
            this.txtTechnologyName.Size = new System.Drawing.Size(157, 26);
            this.txtTechnologyName.TabIndex = 0;
            this.txtTechnologyName.TextChanged += new System.EventHandler(this.txtTechnologyName_TextChanged);
            // 
            // lblTechnologyName
            // 
            this.lblTechnologyName.AutoSize = true;
            this.lblTechnologyName.Location = new System.Drawing.Point(11, 59);
            this.lblTechnologyName.Name = "lblTechnologyName";
            this.lblTechnologyName.Size = new System.Drawing.Size(119, 19);
            this.lblTechnologyName.TabIndex = 0;
            this.lblTechnologyName.Text = "Technology Name";
            // 
            // dgvTechnology
            // 
            this.dgvTechnology.AllowUserToAddRows = false;
            this.dgvTechnology.AllowUserToDeleteRows = false;
            this.dgvTechnology.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnology.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTechnology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnology.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            // TechnologyName
            // 
            this.TechnologyName.DataPropertyName = "TechnologyName";
            this.TechnologyName.HeaderText = "Technology Name";
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
            // frmTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.gbTechnology);
            this.Controls.Add(this.dgvTechnology);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTechnology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technology Master";
            this.Load += new System.EventHandler(this.frmTechnology_Load);
            this.gbTechnology.ResumeLayout(false);
            this.gbTechnology.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnology)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbTechnology;
        private System.Windows.Forms.TextBox txtTechnologyName;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.DataGridView dgvTechnology;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.Button btnClose;
    }
}