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
    public partial class frmSkillSet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmSkillSet()
        {
            InitializeComponent();
        }

        private void frmSkillSet_Load(object sender, EventArgs e)
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
                if (txtSkillName.Text != "")
                {
                    con.Open();
                    string select = "Select * from Tbl_SkillSets where SkillSetName='" + txtSkillName.Text + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("SkillSet already existed. Please Change Department and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtSkillName.Text = "";

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_SkillSets (SkillSetName,CreatedOn) values ('" + txtSkillName.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data saved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        txtSkillName.Text = "";
                        LoadGrid();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Department Name", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkillName.Focus();
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
                string del = "update Tbl_SkillSets set Active=0 where SkillSetName='" + dgvSkillSet.SelectedRows[0].Cells["SkillSetName"].Value.ToString() + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(del, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record De-activeted Successfully.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string select = "Select SkillSetName,CreatedOn from Tbl_SkillSets where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvSkillSet.DataSource = dt;

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
