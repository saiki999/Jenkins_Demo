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
    public partial class frmTechnology : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmTechnology()
        {
            InitializeComponent();
        }

        private void frmTechnology_Load(object sender, EventArgs e)
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
                if (txtTechnologyName.Text != "")
                {
                    con.Open();
                    string select = "Select * from Tbl_Technologys where TechnologyName='" + txtTechnologyName.Text + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Technology already exists. Please Change and try again", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtTechnologyName.Text = "";

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_Technologys (TechnologyName,CreatedOn) values ('" + txtTechnologyName.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data saved Successfully", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        txtTechnologyName.Text = "";
                        LoadGrid();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Technology Name", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTechnologyName.Focus();
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
                string del = "update Tbl_Technologys set Active=0 where TechnologyName='" + dgvTechnology.SelectedRows[0].Cells["TechnologyName"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record De-activated Successfully.", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string select = "Select TechnologyName,CreatedOn from Tbl_Technologys where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvTechnology.DataSource = dt;

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

        private void txtTechnologyName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
