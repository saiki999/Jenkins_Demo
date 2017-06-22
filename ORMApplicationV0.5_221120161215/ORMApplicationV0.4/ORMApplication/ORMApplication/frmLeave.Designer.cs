namespace ORMApplication
{
    partial class frmLeave
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
            this.gbLeave = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.lblLeaveName = new System.Windows.Forms.Label();
            this.dgvLeave = new System.Windows.Forms.DataGridView();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).BeginInit();
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
            // gbLeave
            // 
            this.gbLeave.Controls.Add(this.btnClose);
            this.gbLeave.Controls.Add(this.btnSubmit);
            this.gbLeave.Controls.Add(this.txtLeave);
            this.gbLeave.Controls.Add(this.lblLeaveName);
            this.gbLeave.Location = new System.Drawing.Point(24, 44);
            this.gbLeave.Name = "gbLeave";
            this.gbLeave.Size = new System.Drawing.Size(316, 180);
            this.gbLeave.TabIndex = 6;
            this.gbLeave.TabStop = false;
            this.gbLeave.Text = "Add Leave Type";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLeave
            // 
            this.txtLeave.Location = new System.Drawing.Point(145, 56);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(157, 26);
            this.txtLeave.TabIndex = 0;
            // 
            // lblLeaveName
            // 
            this.lblLeaveName.AutoSize = true;
            this.lblLeaveName.Location = new System.Drawing.Point(11, 59);
            this.lblLeaveName.Name = "lblLeaveName";
            this.lblLeaveName.Size = new System.Drawing.Size(121, 19);
            this.lblLeaveName.TabIndex = 0;
            this.lblLeaveName.Text = "Leave Type Name";
            // 
            // dgvLeave
            // 
            this.dgvLeave.AllowUserToAddRows = false;
            this.dgvLeave.AllowUserToDeleteRows = false;
            this.dgvLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveType,
            this.CreatedOn});
            this.dgvLeave.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLeave.Location = new System.Drawing.Point(377, 54);
            this.dgvLeave.Name = "dgvLeave";
            this.dgvLeave.ReadOnly = true;
            this.dgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeave.Size = new System.Drawing.Size(383, 315);
            this.dgvLeave.TabIndex = 0;
            // 
            // LeaveType
            // 
            this.LeaveType.DataPropertyName = "LeaveType";
            this.LeaveType.HeaderText = "Leave Type";
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.ReadOnly = true;
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
            // frmLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.gbLeave);
            this.Controls.Add(this.dgvLeave);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave ";
            this.Load += new System.EventHandler(this.frmLeave_Load);
            this.gbLeave.ResumeLayout(false);
            this.gbLeave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbLeave;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.Label lblLeaveName;
        private System.Windows.Forms.DataGridView dgvLeave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.Button btnClose;
    }
}