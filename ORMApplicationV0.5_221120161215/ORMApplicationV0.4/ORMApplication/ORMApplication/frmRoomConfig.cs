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
    public partial class frmRoomConfig : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmRoomConfig()
        {
            InitializeComponent();
        }

        private void frmRoomConfig_Load(object sender, EventArgs e)
        {
            loadProjects();
            loadRooms();
            loadTechnologys();
            LoadGrid();
            ddlTechnologyName.Text= "";
            ddlProjectFK.Text = "";
            ddlRoomName.Text = "";


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

        public void loadRooms()
        {
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Rooms where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlRoomName.DisplayMember = "RoomName";
                    ddlRoomName.ValueMember = "RoomPK";
                    ddlRoomName.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("select * from Tbl_Technologys where Active=1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ddlTechnologyName.DisplayMember = "TechnologyName";
                    ddlTechnologyName.ValueMember = "TechPK";
                    ddlTechnologyName.DataSource = dt;
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
                if (btnSubmit.Text == "Update")
                {
                    con.Close();
                    con.Open();
                    string Update = "Update Tbl_RoomConfig set ProjectFK='" + ddlProjectFK.SelectedValue + "',RoomFK='" + ddlRoomName.SelectedValue + "',TechRoomFK='" + ddlTechnologyName.SelectedValue + "',UpdatedOn='" + DateTime.Now + "' where RoomConfigPK='" + lblRoomConfigPK.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(Update, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.Close();
                }
                else
                {
                    con.Open();
                    string select = "Select * from Tbl_RoomConfig where ProjectFK='" + ddlProjectFK.SelectedValue + "' and RoomFK='" + ddlRoomName.SelectedValue + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Room already existed with same Technology. Please Change and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_RoomConfig (ProjectFK,RoomFK,TechRoomFK,CreatedOn) values ('" + ddlProjectFK.SelectedValue + "','" + ddlRoomName.SelectedValue + "','" + ddlTechnologyName.SelectedValue + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show( "Datasaved Successfully","Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();

                    }
                }
                LoadGrid();
                con.Close();
                ddlProjectFK.SelectedIndex = -1;
                ddlRoomName.SelectedIndex = -1;
                ddlTechnologyName.SelectedIndex = -1;
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
                string select = "Select RoomConfigPK,ProjectName,RoomName,TechnologyName from Tbl_RoomConfigDOC where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvRoomConfig.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ControlValidations()
        {
           
            if (ddlProjectFK.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Project", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlProjectFK.Focus();
                return false;
            }
            else if (ddlRoomName.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Room", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlProjectFK.Focus();
                return false;
            }
            else if (ddlTechnologyName.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Technology", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlProjectFK.Focus();
                return false;
            }
            return true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//dgvCarDetails.SelectedRows[0].Cells["CarName"].Value.ToString()

                con.Open();
                string select = "Select * from Tbl_RoomConfigDOC where RoomConfigPK='" + dgvRoomConfig.SelectedRows[0].Cells["RoomConfigPK"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    ddlProjectFK.Text = dr1["ProjectName"].ToString();
                    ddlRoomName.Text = dr1["RoomName"].ToString();
                    ddlTechnologyName.Text = dr1["TechnologyName"].ToString();
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
                string del = "update Tbl_RoomConfig set Active=0 where RoomConfigPK='" + dgvRoomConfig.SelectedRows[0].Cells["RoomConfigPK"].Value.ToString() + "'";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
