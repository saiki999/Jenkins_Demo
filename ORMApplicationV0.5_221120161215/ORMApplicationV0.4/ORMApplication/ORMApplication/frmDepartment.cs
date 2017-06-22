using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ORMApplication
{
    public partial class frmDepartment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeptName.Text != "")
                {
                    con.Open();
                    string select = "Select * from Tbl_Departments where DeptName='"+txtDeptName.Text+"' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Department already existed. Please Change Department and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtDeptName.Text = "";
                        
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_Departments (DeptName,CreatedOn) values ('" + txtDeptName.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        txtDeptName.Text = "";
                        LoadGrid();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter DepartmentName", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeptName.Focus();
                }
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
                string del = "update Tbl_Departments set Active=0 where DeptName='" + dgvDepartment.SelectedRows[0].Cells["DepartmentName"].Value.ToString() + "'";
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
                string select = "Select DeptName,CreatedOn from Tbl_Departments where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvDepartment.DataSource = dt;

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

         

        //private void editToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()
               
        //            con.Open();
        //            string select = "Select * from Tbl_Departments where DeptName='" + dgvDepartment.SelectedRows[0].Cells["DepartmentName"].Value.ToString() + "'";
        //            SqlCommand cmd = new SqlCommand(select, con);
        //            SqlDataReader dr;
        //            dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                txtDeptName.Text = dr["DeptName"].ToString();
        //            }                   

        //            con.Close();
                
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
