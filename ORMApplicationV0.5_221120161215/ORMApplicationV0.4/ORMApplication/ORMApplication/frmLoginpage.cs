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
    public partial class frmLoginpage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmLoginpage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             if (ControlValidations() == false)
                return;
             try
             {
                 ClsVariables.EmployeeID = txtEmployeeID.Text;

                 string sele = "select UserType from Tbl_Employees where EmployeeID='" + txtEmployeeID.Text + "' and Password='" + txtPassword.Text + "'";
                 SqlCommand cmd = new SqlCommand(sele, con);
                 con.Open();
                 SqlDataReader dr;
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     string result = dr[0].ToString();

                     if (result == "Admin")
                     {
                         this.Hide();
                         frmDashBoard fad = new frmDashBoard();
                         fad.ShowDialog();
                        // this.Dispose();
                     }
                     else
                     {
                         this.Hide();
                         frmUserDashBoard fud = new frmUserDashBoard();
                         fud.ShowDialog();
                         //this.Dispose();
                     }
                 }
                 else
                 {
                     MessageBox.Show("EmployeeID or Password Invalid.", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("Please Enter Employee ID", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeID.Focus();
                return false;
            }

            
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginpage_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Focus();
        }
    }
}
