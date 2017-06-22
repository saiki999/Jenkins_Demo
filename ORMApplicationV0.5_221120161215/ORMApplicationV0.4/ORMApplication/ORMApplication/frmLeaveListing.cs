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
    public partial class frmLeaveListing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmLeaveListing()
        {
            InitializeComponent();
        }
        public void loadProjects()
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Projects where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    ddlProject.DisplayMember = "ProjectName";
                    ddlProject.ValueMember = "ProjectPK";
                    ddlProject.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLeaveListing_Load(object sender, EventArgs e)
        {
            loadProjects();
            LoadGrid();
        }

        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select LeaveConfigPK,EmployeeID,ProjectName,LeaveType,LeaveSD,LeaveED,LeaveStatus from Tbl_LeaveConfigDOC where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvLeaveListing.DataSource = dt;

                

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
                string LeaveStatus="Accepted";
                string del = "update Tbl_LeaveConfig set LeaveStatus='" + LeaveStatus + "' where LeaveConfigPK='" + dgvLeaveListing.SelectedRows[0].Cells["LeaveConfigPK"].Value.ToString() + "'";
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
                string LeaveStatus = "Rejected";
                string del = "update Tbl_LeaveConfig set LeaveStatus='" + LeaveStatus + "' where LeaveConfigPK='" + dgvLeaveListing.SelectedRows[0].Cells["LeaveConfigPK"].Value.ToString() + "'";
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

        private void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadGridByProject();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LoadGridByProject()
        {
            try
            {

                con.Open();
                string select = "Select LeaveConfigPK,EmployeeID,ProjectName,LeaveType,LeaveSD,LeaveED,LeaveStatus from Tbl_LeaveConfigDOC where Active=1 and ProjectFK='" + ddlProject.SelectedValue + "'";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvLeaveListing.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
         
    }
}
