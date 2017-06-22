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
    public partial class frmConferenceListing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmConferenceListing()
        {
            InitializeComponent();
        }

        private void frmConferenceListing_Load(object sender, EventArgs e)
        {
            LoadGrid();
            loadEmployees();
        }

        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select ConferencePK,EmployeeID,DateOfBooking,BookingTime,HallStatus from Tbl_ConferenceHall where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvConferenceListing.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void loadEmployees()
        {
            try
            {

                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct(EmployeeID) from Tbl_Employees where Active=1", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ddlEmployee.Items.Add(dr["EmployeeID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string HallStatus = "Accepted";
                string del = "update Tbl_ConferenceHall set HallStatus='" + HallStatus + "' where ConferencePK='" + dgvConferenceListing.SelectedRows[0].Cells["ConferencePK"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Accepted Successfully.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string HallStatus = "Rejected";
                string del = "update Tbl_ConferenceHall set HallStatus='" + HallStatus + "' where ConferencePK='" + dgvConferenceListing.SelectedRows[0].Cells["ConferencePK"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Rejected Successfully.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadGridByEmployee();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LoadGridByEmployee()
        {
            try
            {
                con.Close();
                con.Open();
                string select = "Select ConferencePK,EmployeeID,DateOfBooking,BookingTime,HallStatus from Tbl_ConferenceHall where Active=1 and EmployeeID='" + ddlEmployee.SelectedItem.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvConferenceListing.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

         

    }
}
