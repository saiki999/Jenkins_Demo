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
    public partial class frmProject : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmProject()
        {
            InitializeComponent();
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            LoadGrid();
            loadEmployees();
            ddlManagerFK.Text = "";
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
                    ddlManagerFK.DisplayMember = "FName";
                    ddlManagerFK.ValueMember = "EmployeePK";
                    ddlManagerFK.DataSource = dt;
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
                if (Convert.ToDateTime(dtpStartDate.Text) <= Convert.ToDateTime(dtpEndDate.Text))
                {


                    if (btnSubmit.Text == "Update")
                    {
                        con.Close();
                        con.Open();
                        string Update = "Update Tbl_Projects set ProjectName='" + txtProjectName.Text + "',ProjectSD='" + dtpStartDate.Value + "',ProjectED='" + dtpEndDate.Value + "',ProjectMgrFK='" + ddlManagerFK.SelectedValue + "',ClientName='" + txtClientName.Text + "',ClientPhoneNo='" + txtClientPhNo.Text + "',ClientEmail='" + txtClientEmail.Text + "',UpdatedOn='" + DateTime.Now + "' where ProjectPK='" + lblProjectPK.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(Update, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                    }
                    else
                    {
                        string select = "Select * from Tbl_Projects where ProjectName='" + txtProjectName.Text + "' and Active=1";
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
                            string insert = "insert into Tbl_Projects (ProjectName,ProjectSD,ProjectED,ProjectMgrFK,ClientName,ClientPhoneNo,ClientEmail,CreatedOn) values ('" + txtProjectName.Text + "','" + dtpStartDate.Value + "','" + dtpEndDate.Value + "','" + ddlManagerFK.SelectedValue + "','" + txtClientName.Text + "','" + txtClientPhNo1.Text + "','" + txtClientEmail.Text + "','" + DateTime.Now + "')";
                            SqlCommand cmd1 = new SqlCommand(insert, con);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Data saved Successfully", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                            con.Close();
                        }
                    }
                    con.Close();
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Project Start Date must be greater than Project End Date", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                txtProjectName.Text = "";
                txtClientEmail.Text = "";
                txtClientPhNo.Text = "";
                txtClientEmail.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ControlValidations()
        {
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("Please Enter Project Name", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProjectName.Focus();
                return false;
            }

            else if (ddlManagerFK.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Manager", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlManagerFK.Focus();
                return false;
            }           
            else if (txtClientName.Text == "")
            {
                MessageBox.Show("Please Enter Client Name", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClientName.Focus();
                return false;
            }
            else if (txtClientPhNo.Text == "")
            {
                MessageBox.Show("Please Enter Client Phone No", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClientPhNo1.Focus();
                return false;
            }
            else if (txtClientEmail.Text == "")
            {
                MessageBox.Show("Please Enter Client Email", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClientEmail.Focus();
                return false;
            }
            return true;
        }

        public void LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select ProjectPK,ProjectName,ProjectSD,ProjectED,ProjectMgrName,ClientName,ClientPhoneNo,ClientEmail from Tbl_ProjectsDoc where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvProject.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()

                con.Open();
                string select = "Select * from Tbl_Projects where ProjectPK='" + dgvProject.SelectedRows[0].Cells["ProjectPK"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    
                    lblProjectPK.Text = dr1["ProjectPK"].ToString();
                    txtProjectName.Text = dr1["ProjectName"].ToString();
                    dtpStartDate.Text = dr1["ProjectSD"].ToString();
                    dtpEndDate.Text = dr1["ProjectED"].ToString();
                   // ddlManagerFK.SelectedValue = dr1["ProjectED"].ToString();

                    txtClientName.Text = dr1["ClientName"].ToString();
                    txtClientPhNo1.Text = dr1["ClientPhoneNo"].ToString();
                    txtClientEmail.Text = dr1["ClientEmail"].ToString();
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
                string del = "update Tbl_Projects set Active=0 where ProjectPK='" + dgvProject.SelectedRows[0].Cells["ProjectPK"].Value.ToString() + "'";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
