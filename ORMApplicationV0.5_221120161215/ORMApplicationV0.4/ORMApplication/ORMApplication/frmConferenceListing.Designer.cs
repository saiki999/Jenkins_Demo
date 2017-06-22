namespace ORMApplication
{
    partial class frmConferenceListing
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
            this.ddlEmployee = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvConferenceListing = new System.Windows.Forms.DataGridView();
            this.ConferencePK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrject = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferenceListing)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlEmployee
            // 
            this.ddlEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmployee.FormattingEnabled = true;
            this.ddlEmployee.Location = new System.Drawing.Point(386, 34);
            this.ddlEmployee.Name = "ddlEmployee";
            this.ddlEmployee.Size = new System.Drawing.Size(157, 27);
            this.ddlEmployee.TabIndex = 7;
            this.ddlEmployee.SelectedIndexChanged += new System.EventHandler(this.ddlEmployee_SelectedIndexChanged);
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
            // dgvConferenceListing
            // 
            this.dgvConferenceListing.AllowUserToAddRows = false;
            this.dgvConferenceListing.AllowUserToDeleteRows = false;
            this.dgvConferenceListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConferenceListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvConferenceListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConferenceListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConferencePK,
            this.EmployeeID,
            this.DateOfBooking,
            this.BookingTime,
            this.HallStatus});
            this.dgvConferenceListing.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvConferenceListing.Location = new System.Drawing.Point(72, 99);
            this.dgvConferenceListing.Name = "dgvConferenceListing";
            this.dgvConferenceListing.ReadOnly = true;
            this.dgvConferenceListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConferenceListing.Size = new System.Drawing.Size(749, 275);
            this.dgvConferenceListing.TabIndex = 9;
            // 
            // ConferencePK
            // 
            this.ConferencePK.DataPropertyName = "ConferencePK";
            this.ConferencePK.HeaderText = "ConferencePK";
            this.ConferencePK.Name = "ConferencePK";
            this.ConferencePK.ReadOnly = true;
            this.ConferencePK.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Name";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // DateOfBooking
            // 
            this.DateOfBooking.DataPropertyName = "DateOfBooking";
            this.DateOfBooking.HeaderText = "DOB";
            this.DateOfBooking.Name = "DateOfBooking";
            this.DateOfBooking.ReadOnly = true;
            // 
            // BookingTime
            // 
            this.BookingTime.DataPropertyName = "BookingTime";
            this.BookingTime.HeaderText = "Time";
            this.BookingTime.Name = "BookingTime";
            this.BookingTime.ReadOnly = true;
            // 
            // HallStatus
            // 
            this.HallStatus.DataPropertyName = "HallStatus";
            this.HallStatus.HeaderText = "Status";
            this.HallStatus.Name = "HallStatus";
            this.HallStatus.ReadOnly = true;
            // 
            // lblPrject
            // 
            this.lblPrject.AutoSize = true;
            this.lblPrject.Location = new System.Drawing.Point(250, 38);
            this.lblPrject.Name = "lblPrject";
            this.lblPrject.Size = new System.Drawing.Size(110, 19);
            this.lblPrject.TabIndex = 8;
            this.lblPrject.Text = "Select Employee";
            // 
            // frmConferenceListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 408);
            this.Controls.Add(this.ddlEmployee);
            this.Controls.Add(this.dgvConferenceListing);
            this.Controls.Add(this.lblPrject);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConferenceListing";
            this.Text = "Conference Listing";
            this.Load += new System.EventHandler(this.frmConferenceListing_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferenceListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlEmployee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvConferenceListing;
        private System.Windows.Forms.Label lblPrject;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConferencePK;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallStatus;
    }
}