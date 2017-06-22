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
    public partial class frmTeamMapping : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmTeamMapping()
        {
            InitializeComponent();
        }

        private void frmTeamMapping_Load(object sender, EventArgs e)
        {
           

            loadProjects();
            loadEmployees();
            LoadGrid();
            ddlProjectFK.Text = "";
            if (ClsVariables.teampk > 0)
            {
                try
                {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()
                    lblTeamMappingPK.Text =Convert.ToString(ClsVariables.teampk);
                    btnSubmit.Text = "Update";
                    con.Close();
                    con.Open();
                    string select = "Select * from Tbl_TeamMappingDOC where TeamMappingPK='" + ClsVariables.teampk + "'";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr1;
                    dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        lblTeamMappingPK.Text = dr1["TeamMappingPK"].ToString();
                        ddlEmployeeFK.Text = dr1["FName"].ToString();
                        ddlProjectFK.Text = dr1["ProjectName"].ToString();
                        ddlResourceType.Text = dr1["ResourceType"].ToString();
                        dtpStartDate.Text = dr1["EmployeeSD"].ToString();
                        dtpEndDate.Text = dr1["EmployeeED"].ToString();
                        btnSubmit.Text = "Update";
                    }
                    dr1.Close();
                    con.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select TeamMappingPK,ProjectName,EmployeeID,EmployeeSD,EmployeeED from Tbl_TeamMappingDoc where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvTeamMapping.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                    ddlProjectFK.DisplayMember = "ProjectName";
                    ddlProjectFK.ValueMember = "ProjectPK";
                    ddlProjectFK.DataSource = dt;
                }

                con.Close();
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
                    ddlEmployeeFK.Items.Add(dr["EmployeeID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ControlValidations() == false)
                return;
            try
            {
                if (btnSubmit.Text == "Update")
                {
                    con.Close();
                    con.Open();
                    string Update = "Update Tbl_TeamMapping set ProjectFK='" + ddlProjectFK.SelectedValue + "',EmployeeID='" + ddlEmployeeFK.SelectedItem.ToString() + "',EmployeeSD='" + dtpStartDate.Value + "',EmployeeED='" + dtpEndDate.Value + "',ResourceType='"+ddlResourceType.SelectedItem.ToString()+"',UpdatedOn='" + DateTime.Now + "' where TeamMappingPK='" + lblTeamMappingPK.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(Update, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.Close();
                   

                }
                else
                {
                    con.Close();
                    string select = "Select * from Tbl_TeamMapping where ProjectFK='" + ddlProjectFK.SelectedValue + "' and EmployeeID='"+ddlEmployeeFK.SelectedItem.ToString()+"' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Employee already existed. Please Change Employee and try again", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_TeamMapping (ProjectFK,EmployeeID,EmployeeSD,EmployeeED,ResourceType,CreatedOn) values ('" + ddlProjectFK.SelectedValue + "','" + ddlEmployeeFK.SelectedItem.ToString() + "','" + dtpStartDate.Value + "','" + dtpEndDate.Value + "','" + ddlResourceType.SelectedItem.ToString() + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Datasaved Successfully", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                    }
                }
                con.Close();
                LoadGrid();
                 ddlProjectFK.SelectedIndex=-1;
                 ddlResourceType.SelectedIndex = -1;
                 ddlEmployeeFK.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ControlValidations()
        {
             
             if (ddlProjectFK.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Project", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlProjectFK.Focus();
                return false;
            }
            else if (ddlEmployeeFK.SelectedIndex==-1)
            {
                MessageBox.Show("Please select Employee", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlEmployeeFK.Focus();
                return false;
            }
             else if (ddlResourceType.SelectedIndex == -1)
             {
                 MessageBox.Show("Please select Resource Type", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ddlResourceType.Focus();
                 return false;
             }
            return true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()
                con.Close();
                con.Open();
                string select = "Select * from Tbl_TeamMappingDOC where TeamMappingPK='" + dgvTeamMapping.SelectedRows[0].Cells["TeamMappingPK"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    lblTeamMappingPK.Text = dr1["TeamMappingPK"].ToString();
                    ddlEmployeeFK.Text = dr1["EmployeeID"].ToString();
                    ddlProjectFK.Text = dr1["ProjectName"].ToString();
                    ddlResourceType.Text = dr1["ResourceType"].ToString();
                    dtpStartDate.Text = dr1["EmployeeSD"].ToString();
                    dtpEndDate.Text = dr1["EmployeeED"].ToString();
                    btnSubmit.Text = "Update";
                }
                dr1.Close();
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "update Tbl_TeamMapping set Active=0 where TeamMappingPK='" + dgvTeamMapping.SelectedRows[0].Cells["TeamMappingPK"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Deactivated Successfully.", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ddlProjectFK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
