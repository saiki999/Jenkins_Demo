using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORMApplication
{
    public partial class frmUserDashBoard : Form
    {
        public frmUserDashBoard()
        {
            InitializeComponent();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                frmLeaveConfig flc = new frmLeaveConfig();
                flc.TopLevel = false;
                flc.FormBorderStyle = FormBorderStyle.None;
                pnlHome.Controls.Clear();
                pnlHome.Controls.Add(flc);
                flc.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfencere_Click(object sender, EventArgs e)
        {
            try
            {
                 
                frmConference fc = new frmConference();
                fc.TopLevel = false;
                fc.FormBorderStyle = FormBorderStyle.None;
                pnlHome.Controls.Clear();
                pnlHome.Controls.Add(fc);
                fc.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginpage fl = new frmLoginpage();
            fl.Show();
            
        }
    }
}
