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
    public partial class frmTechnologyConfig : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmTechnologyConfig()
        {
            InitializeComponent();
        }

        private void frmTechnologyConfig_Load(object sender, EventArgs e)
        {
            try
            {
                loadRooms();
                loadTechnologys();
                LoadGrid();
                ddlRoomFK.Text = "";
                ddlTechFK.Text = "";
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

                string select = "Select * from Tbl_TechRooms where RoomFK='" + ddlRoomFK.SelectedValue + "' and TechFK='" + ddlTechFK.SelectedValue + "' and Active=1";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    MessageBox.Show("This Room already existed with same Technology. Please Change and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    con.Close();
                    con.Open();
                    string insert = "insert into Tbl_TechRooms (RoomFK,TechFK,CreatedOn) values ('" + ddlRoomFK.SelectedValue + "','" + ddlTechFK.SelectedValue + "','" + DateTime.Now + "')";
                    SqlCommand cmd1 = new SqlCommand(insert, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data saved Successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.Close();
                    LoadGrid();
                }
                con.Close();
                ddlTechFK.SelectedIndex = -1;
                ddlRoomFK.SelectedIndex = -1;
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
                string select = "Select TechRoomPK,RoomFK,RoomName,TechFK,TechnologyName,CreatedOn from Tbl_TechRoomsDOC where Active=1";

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
                    ddlRoomFK.DisplayMember = "RoomName";
                    ddlRoomFK.ValueMember = "RoomPK";
                    ddlRoomFK.DataSource = dt;
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
                    ddlTechFK.DisplayMember = "TechnologyName";
                    ddlTechFK.ValueMember = "TechPK";
                    ddlTechFK.DataSource = dt;
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

            if (ddlRoomFK.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Department", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlRoomFK.Focus();
                return false;
            }
            else if (ddlTechFK.SelectedIndex ==-1)
            {
                MessageBox.Show("Please Enter Designation", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlTechFK.Focus();
                return false;
            }
            return true;
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "update Tbl_TechRooms set Active=0 where TechRoomPK='" + dgvTechnology.SelectedRows[0].Cells["TechRoomPK"].Value.ToString() + "'";
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

        private void ddlRoomFK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
