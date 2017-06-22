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
    public partial class frmRooms : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmRooms()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomName.Text != "")
                {
                    con.Open();
                    string select = "Select * from Tbl_Rooms where RoomName='" + txtRoomName.Text + "' and Active=1";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Skill Set already existed. Please Change Department and try again", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtRoomName.Text = "";

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string insert = "insert into Tbl_Rooms (RoomName,CreatedOn) values ('" + txtRoomName.Text + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        txtRoomName.Text = "";
                        LoadGrid();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Department Name", "Orginization Rresource Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRoomName.Focus();
                }
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
                string select = "Select RoomName,CreatedOn from Tbl_Rooms where Active=1";

                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                con.Close();
                dgvRoom.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmRooms_Load(object sender, EventArgs e)
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

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "update Tbl_Rooms set Active=0 where RoomName='" + dgvRoom.SelectedRows[0].Cells["RoomName"].Value.ToString() + "'";
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
