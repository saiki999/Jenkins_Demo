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
    public partial class frmDesignation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void frmDesignation_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                loadDepartments();
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

                    string select = "Select * from Tbl_Designations where DeptFK='" + ddlDeptFK.SelectedValue+ "' and DesgName='" + txtDesgName.Text + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Designation already existed. Please Change Designation and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                       
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_Designations (DeptFK,DesgName,CreatedOn) values ('"+ddlDeptFK.SelectedValue+"','" + txtDesgName.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();                        
                        LoadGrid();
                    }
                    con.Close();
                    txtDesgName.Text = "";
                    ddlDeptFK.SelectedIndex = -1;
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
                string del = "update Tbl_Designations set Active=0 where DesgPK='" + dgvDesignation.SelectedRows[0].Cells["DesgPK"].Value.ToString() + "'";
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

        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select DesgPK,DeptFK,DeptName,DesgName,CreatedOn from Tbl_DesignationsDOC where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvDesignation.DataSource = dt;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void loadDepartments()
        {
            try
            {
               
               
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Departments where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlDeptFK.DisplayMember = "DeptName";
                    ddlDeptFK.ValueMember = "DeptPK";
                    ddlDeptFK.DataSource = dt;
                }

                con.Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



       

        private bool ControlValidations()
        {

            if (ddlDeptFK.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Department", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlDeptFK.Focus();
                return false;
            }
            else if (txtDesgName.Text == "")
            {
                MessageBox.Show("Please Enter Designation", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesgName.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

         

       
    }
}
