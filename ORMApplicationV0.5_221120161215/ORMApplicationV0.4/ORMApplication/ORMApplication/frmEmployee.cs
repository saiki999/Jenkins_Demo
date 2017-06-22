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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                loadDepartments();
                loadDesignations();
                ddlDeptName.Text = "";
                ddlDesgName.Text = "";
               
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
                    ddlDeptName.DisplayMember = "DeptName";
                    ddlDeptName.ValueMember = "DeptPK";
                    ddlDeptName.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDesignations()
        {
            try
            {

                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Designations where Active=1 and DeptFK='" + ddlDeptName.SelectedValue + "'", con);
               // SqlCommand cmd = new SqlCommand("select * from Tbl_Designations where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlDesgName.DisplayMember = "DesgName";
                    ddlDesgName.ValueMember = "DesgPK";
                    ddlDesgName.DataSource = dt;
                    con.Close();

                }
                else
                {
                    ddlDesgName.SelectedIndex = -1;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void ddlDeptFK_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        loadDesignations();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ControlValidations() == false)
                return;
            try
            {

                string select2 = "Select * from Tbl_Employees where EmployeeID='" + txtEmployeeID.Text + "' and Active=1";
                SqlCommand cmd2 = new SqlCommand(select2, con);
                SqlDataReader dr2;
                con.Open();
                dr2 = cmd2.ExecuteReader();
               
                 if (dr2.Read())
                {
                    
                    MessageBox.Show("Employee already existed. Please Change EmployeeID and try again", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                   
                }

                else
                {
                  
                    if (btnSubmit.Text == "Update")
                    {
                        con.Close();
                        con.Open();
                        string Update = "Update Tbl_Employees set FName='" + txtEmployeeName.Text + "',LName='" + txtLastName.Text + "',DeptFK='" + ddlDeptName.SelectedValue + "',DesgFK='" + ddlDesgName.SelectedValue + "',PhoneNo='" + txtPhoneNo.Text + "',Password='" + txtPassword.Text + "',UserType='" + ddlUserType.SelectedItem.ToString() + "',Email='" + txtEmail.Text + "',Address='" + txtAddress.Text + "',UpdatedOn='" + DateTime.Now + "' where EmployeeID='" + lblEmployeePK.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(Update, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                    }
                    else
                    {
                        
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_Employees (EmployeeID,FName,LName,DeptFK,DesgFK,PhoneNo,Password,UserType,Email,Address,CreatedOn) values ('" + txtEmployeeID.Text + "','" + txtEmployeeName.Text + "','" + txtLastName.Text + "','" + ddlDeptName.SelectedValue + "','" + ddlDesgName.SelectedValue + "','" + txtPhoneNo.Text + "','" + txtPassword.Text + "','" + ddlUserType.SelectedItem.ToString() + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Datasaved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();                  
                    
                        }
            }

                dr2.Close();
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
                string select = "Select EmployeePK,FName,DeptName,DesgName,PhoneNo,Email,UserType from Tbl_EmployeesDOC where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvEmployeeList.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool ControlValidations()
        {
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Please Enter Employee Name", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeName.Focus();
                return false;
            }

            else if (ddlDeptName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Department", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlDeptName.Focus();
                return false;
            }
            else if (ddlDesgName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Designation", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlDesgName.Focus();
                return false;
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Enter PhoneNo", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNo.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Organization Resource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            return true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()

                con.Open();
                string select = "Select * from Tbl_EmployeesDOC where EmployeePK='" + dgvEmployeeList.SelectedRows[0].Cells["EmployeePK"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    lblEmployeePK.Text = dr1["EmployeeID"].ToString();
                    txtEmployeeID.Text = dr1["EmployeeID"].ToString();
                    txtEmployeeName.Text = dr1["FName"].ToString();
                    txtLastName.Text = dr1["LName"].ToString();
                    ddlDeptName.Text = dr1["DeptName"].ToString();
                    ddlDesgName.Text = dr1["DesgName"].ToString();
                    txtAddress.Text = dr1["Address"].ToString();
                    txtPassword.Text = dr1["Password"].ToString();
                    ddlUserType.Text = dr1["UserType"].ToString();
                    //loadDesignations();
                    //ddlDesgFK.SelectedValue = dr1["DesgFK"].ToString();

                    txtPhoneNo.Text = dr1["PhoneNo"].ToString();
                    txtEmail.Text = dr1["Email"].ToString();
                    txtEmployeeID.ReadOnly = true;
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
                string del = "update Tbl_Employees set Active=0 where EmployeePK='" + dgvEmployeeList.SelectedRows[0].Cells["EmployeePK"].Value.ToString() + "'";
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

        private void ddlDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
           // loadDesignations();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         

        
    }
}
