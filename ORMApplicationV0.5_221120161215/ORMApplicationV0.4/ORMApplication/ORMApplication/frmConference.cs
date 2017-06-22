using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ORMApplication
{
    public partial class frmConference : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmConference()
        {
            InitializeComponent();
            lblEmployeeID.Text = ClsVariables.EmployeeID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlBT.SelectedItem == null)
            {
                MessageBox.Show( "Please Enter Required Data","Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                //con.Close();
                con.Open();
                string HallStatus = "Pending";
                string insert = "insert into Tbl_ConferenceHall (EmployeeID,DateOfBooking,BookingTime,HallStatus) values ('" + lblEmployeeID.Text + "','" + dtpDOB.Value + "','" + Convert.ToInt32(ddlBT.SelectedItem.ToString()) + "','" + HallStatus + "')";
                SqlCommand cmd1 = new SqlCommand(insert, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                con.Close();
            }
            ddlBT.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
    }
}
