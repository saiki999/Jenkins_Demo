namespace ORMApplication
{
    partial class frmSkillSet
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
            this.gbSkillset = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblSkillSetName = new System.Windows.Forms.Label();
            this.dgvSkillSet = new System.Windows.Forms.DataGridView();
            this.SkillSetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSkillset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillSet)).BeginInit();
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
            // gbSkillset
            // 
            this.gbSkillset.Controls.Add(this.btnClose);
            this.gbSkillset.Controls.Add(this.btnSubmit);
            this.gbSkillset.Controls.Add(this.txtSkillName);
            this.gbSkillset.Controls.Add(this.lblSkillSetName);
            this.gbSkillset.Location = new System.Drawing.Point(24, 44);
            this.gbSkillset.Name = "gbSkillset";
            this.gbSkillset.Size = new System.Drawing.Size(316, 180);
            this.gbSkillset.TabIndex = 2;
            this.gbSkillset.TabStop = false;
            this.gbSkillset.Text = "SkillSet Add";
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
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(145, 56);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(157, 26);
            this.txtSkillName.TabIndex = 0;
            // 
            // lblSkillSetName
            // 
            this.lblSkillSetName.AutoSize = true;
            this.lblSkillSetName.Location = new System.Drawing.Point(11, 59);
            this.lblSkillSetName.Name = "lblSkillSetName";
            this.lblSkillSetName.Size = new System.Drawing.Size(96, 19);
            this.lblSkillSetName.TabIndex = 0;
            this.lblSkillSetName.Text = "SkillSet Name";
            // 
            // dgvSkillSet
            // 
            this.dgvSkillSet.AllowUserToAddRows = false;
            this.dgvSkillSet.AllowUserToDeleteRows = false;
            this.dgvSkillSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkillSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSkillSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkillSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillSetName,
            this.CreatedOn});
            this.dgvSkillSet.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSkillSet.Location = new System.Drawing.Point(377, 54);
            this.dgvSkillSet.Name = "dgvSkillSet";
            this.dgvSkillSet.ReadOnly = true;
            this.dgvSkillSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkillSet.Size = new System.Drawing.Size(383, 315);
            this.dgvSkillSet.TabIndex = 0;
            // 
            // SkillSetName
            // 
            this.SkillSetName.DataPropertyName = "SkillSetName";
            this.SkillSetName.HeaderText = "SkillSet Name";
            this.SkillSetName.Name = "SkillSetName";
            this.SkillSetName.ReadOnly = true;
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
            // frmSkillSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.gbSkillset);
            this.Controls.Add(this.dgvSkillSet);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSkillSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkillSet Master";
            this.Load += new System.EventHandler(this.frmSkillSet_Load);
            this.gbSkillset.ResumeLayout(false);
            this.gbSkillset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbSkillset;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lblSkillSetName;
        private System.Windows.Forms.DataGridView dgvSkillSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillSetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.Button btnClose;
    }
}