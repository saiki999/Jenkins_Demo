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
    public partial class frmTeamListing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmTeamListing()
        {
            InitializeComponent();
        }

        private void frmTeamListing_Load(object sender, EventArgs e)
        {
            
            loadProjects();
            ddlProject.SelectedIndex = -1;
            LoadGrid();
            
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
        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select TeamMappingPK,ProjectName,ClientName,FName,ResourceType from Tbl_TeamMappingDoc where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvTeamListing.DataSource = dt;

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
                string select = "Select TeamMappingPK,ProjectName,ClientName,FName,ResourceType from Tbl_TeamMappingDoc where Active=1 and ProjectFK='" + ddlProject.SelectedValue + "'";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvTeamListing.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClsVariables.teampk = Convert.ToInt32(dgvTeamListing.SelectedRows[0].Cells["TeamMappingPK"].Value.ToString());
            frmTeamMapping tm = new frmTeamMapping();
            tm.Show();           

        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "update Tbl_TeamMapping set Active=0 where TeamMappingPK='" + dgvTeamListing.SelectedRows[0].Cells["TeamMappingPK"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Employee Released Successfully.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
