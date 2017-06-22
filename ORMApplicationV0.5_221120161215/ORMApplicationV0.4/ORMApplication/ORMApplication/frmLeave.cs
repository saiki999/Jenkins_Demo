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
    public partial class frmLeave : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmLeave()
        {
            InitializeComponent();
        }

        private void frmLeave_Load(object sender, EventArgs e)
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
                if (txtLeave.Text != "")
                {
                    con.Open();
                    string select = "Select * from Tbl_LeaveTypes where LeaveType='" + txtLeave.Text + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Technology already existed. Please Change Department and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtLeave.Text = "";

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_LeaveTypes (LeaveType,CreatedOn) values ('" + txtLeave.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        txtLeave.Text = "";
                        LoadGrid();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Orginization Rresource Management", "Please Enter Department Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLeave.Focus();
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
                string del = "update Tbl_LeaveTypes set Active=0 where LeaveType='" + dgvLeave.SelectedRows[0].Cells["LeaveType"].Value.ToString() + "'";
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
                string select = "Select LeaveType,CreatedOn from Tbl_LeaveTypes where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvLeave.DataSource = dt;

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
