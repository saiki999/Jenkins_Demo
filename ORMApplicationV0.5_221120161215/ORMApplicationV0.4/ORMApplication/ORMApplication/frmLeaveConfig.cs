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
    public partial class frmLeaveConfig : Form
    {
        public frmLeaveConfig()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        private void frmLeaveConfig_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = ClsVariables.EmployeeID;
            loadEmployees();
            loadLeaveType();
            loadProjects();
            LoadGrid();
             
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
                    ddlEmployeeFK.DisplayMember = "FName";
                    ddlEmployeeFK.ValueMember = "EmployeePK";
                    ddlEmployeeFK.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadLeaveType()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_LeaveTypes where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlLeaveType.DisplayMember = "LeaveType";
                    ddlLeaveType.ValueMember = "LeavePK";
                    ddlLeaveType.DataSource = dt;
                }

                con.Close();
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
                        string Update = "Update Tbl_LeaveConfig set  leaveFK='" + ddlLeaveType.SelectedValue + "',ProjectFK='" + ddlProjectFK.SelectedValue + "',LeaveSD='" + dtpStartDate.Value + "',LeaveED='" + dtpEndDate.Value + "',Reason='" + txtReason.Text + "',UpdatedOn='" + DateTime.Now + "' where LeaveConfigPK='" + lblLeaveConfigPK.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(Update, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                    }
                    else
                    {
                        string LeaveStatus = "Pending";
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_LeaveConfig (EmployeeID,leaveFK,ProjectFK,LeaveSD,LeaveED,Reason,LeaveStatus,CreatedOn) values ('" + lblEmployeeID.Text + "','" + ddlLeaveType.SelectedValue + "','" + ddlProjectFK.SelectedValue + "','" + dtpStartDate.Value + "','" + dtpEndDate.Value + "','" + txtReason.Text + "','" + LeaveStatus + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Saved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();

                    }
                    con.Close();
                    LoadGrid();
                }
                else 
                {
                    MessageBox.Show("Leave Start Date must be greater than Leave End Date", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void  LoadGrid()
        {
            try
            {

                con.Open();
                string select = "Select LeaveConfigPK,EmployeeID,ProjectName,LeaveType,LeaveStatus from Tbl_LeaveConfigDOC where Active=1 and EmployeeID='" + lblEmployeeID.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvLeaveConfig.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ControlValidations()
        {
             
            if (ddlLeaveType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Leave Type", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlLeaveType.Focus();
                return false;
            }
            else if (ddlEmployeeFK.Text == "")
            {
                MessageBox.Show("Please select Employee", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlEmployeeFK.Focus();
                return false;
            }
           
            else if (txtReason.Text == "")
            {
                MessageBox.Show("Please Enter Reason", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReason.Focus();
                return false;
            }
            return true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()

                con.Open();
                string select = "Select * from Tbl_LeaveConfigDOC where LeaveConfigPK='" + dgvLeaveConfig.SelectedRows[0].Cells["LeaveConfigPK"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    lblLeaveConfigPK.Text = dr1["LeaveConfigPK"].ToString();
                    dtpStartDate.Text = dr1["LeaveSD"].ToString();
                    dtpEndDate.Text = dr1["LeaveED"].ToString();
                    ddlEmployeeFK.Text=dr1["FName"].ToString();
                    ddlLeaveType.Text = dr1["LeaveType"].ToString();
                    ddlProjectFK.Text = dr1["ProjectName"].ToString(); 
                    txtReason.Text = dr1["Reason"].ToString();
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
                string del = "update Tbl_LeaveConfig set Active=0 where LeaveConfigPK='" + dgvLeaveConfig.SelectedRows[0].Cells["LeaveConfigPK"].Value.ToString() + "'";
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
