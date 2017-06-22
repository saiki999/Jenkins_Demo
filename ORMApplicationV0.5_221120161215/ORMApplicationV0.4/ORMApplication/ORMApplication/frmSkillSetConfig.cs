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
    public partial class frmSkillSetConfig : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmSkillSetConfig()
        {
            InitializeComponent();
        }

        private void frmSkillSetConfig_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                loadEmployees();
                loadTechnologys();
                ddlEmployeeName.Text = "";
                ddlSkillSetName.Text = "";

               // LoadGrid();
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


                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Employees where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlEmployeeName.DisplayMember = "FName";
                    ddlEmployeeName.ValueMember = "EmployeePK";
                    ddlEmployeeName.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadTechnologys()
        {
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_SkillSets where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlSkillSetName.DisplayMember = "SkillSetName";
                    ddlSkillSetName.ValueMember = "SkillSetPK";
                    ddlSkillSetName.DataSource = dt;
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
                string select = "Select SkillConfigPK,FName,SkillSetName,CreatedOn from Tbl_SkillSetConfigDOC where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvSkillSetConfig.DataSource = dt;

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

                con.Open();

                string select = "Select * from Tbl_SkillSetConfig where EmployeeFK='" + ddlEmployeeName.SelectedValue + "' and SkillSetFK='" + ddlSkillSetName.SelectedValue + "' and Active=1";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    MessageBox.Show("Configuration already existed. Please change Configuration and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    con.Close();
                    con.Open();
                    string insert = "insert into Tbl_SkillSetConfig (EmployeeFK,SkillSetFK,CreatedOn) values ('" + ddlEmployeeName.SelectedValue + "','" + ddlSkillSetName.SelectedValue + "','" + DateTime.Now + "')";
                    SqlCommand cmd1 = new SqlCommand(insert, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.Close();
                    LoadGrid();
                }
                con.Close();               
                ddlEmployeeName.SelectedIndex = -1;
                ddlSkillSetName.SelectedValue = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ControlValidations()
        {

            if (ddlEmployeeName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Employee", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlEmployeeName.Focus();
                return false;
            }
            else if (ddlSkillSetName.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter SkillSet Name", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlSkillSetName.Focus();
                return false;
            }
            return true;
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "update Tbl_SkillSetConfig set Active=0 where SkillConfigPK='" + dgvSkillSetConfig.SelectedRows[0].Cells["SkillConfigPK"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Deactiveted Successfully.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
