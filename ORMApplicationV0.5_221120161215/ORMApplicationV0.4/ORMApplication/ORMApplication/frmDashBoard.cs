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
    public partial class frmDashBoard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ORM_DB;Integrated Security=True");
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            frmProject fp = new frmProject();
             fp.Show();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            LoadDashboardCnt();
        }

        public void LoadDashboardCnt()
        {
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("DashBoardCount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblProjectCount.Text=dr["Projectcnt"].ToString();
                    lblDeptCnt.Text = dr["Departmentcnt"].ToString();
                    lblDesgCnt.Text = dr["Designationcnt"].ToString();
                    lblLeaveCount.Text = dr["Leavecnt"].ToString();
                    lblLr.Text = dr["leavestatusVW"].ToString();
                    lblHr.Text = dr["CHallStatusVW"].ToString();
                    lblEmployeeCount.Text = dr["Employeecnt"].ToString();
                    lblHallCount.Text = dr["HallStatusVW"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee fe = new frmEmployee();
            fe.Show();
        }



        private void btnLeaveConfig_Click(object sender, EventArgs e)
        {
            frmLeaveConfig flc = new frmLeaveConfig();
            flc.Show();

        }

        private void btnLeaveMaster_Click(object sender, EventArgs e)
        {
            frmLeave flm = new frmLeave();
            flm.Show();
        }

        private void btnTechMaster_Click(object sender, EventArgs e)
        {
            frmTechnology ft = new frmTechnology();
            ft.Show();

        }

        

        private void btnRoomConfig_Click(object sender, EventArgs e)
        {
            frmRoomConfig frcnfig = new frmRoomConfig();
            frcnfig.Show();
            //frmTechnologyConfig ftmc = new frmTechnologyConfig();

            //ftmc.Show();
        }

        private void btnRoomMaster_Click(object sender, EventArgs e)
        {
            frmRooms frm = new frmRooms();
            frm.Show();
        }

        private void btnSkillSetMaster_Click(object sender, EventArgs e)
        {
            frmSkillSet fssm = new frmSkillSet();
            fssm.Show();
        }

        private void btnProjectConfig_Click(object sender, EventArgs e)
        {
            frmTeamMapping ftm = new frmTeamMapping();
            ftm.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment fd= new frmDepartment();
            fd.Show();
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            frmDesignation fdesg = new frmDesignation();
            fdesg.Show();
        }

        private void btnEmpSkillConfig_Click(object sender, EventArgs e)
        {
            frmSkillSetConfig fesc= new frmSkillSetConfig();
            fesc.Show();
        }

        private void btnProjectOverview_Click(object sender, EventArgs e)
        {
            frmTeamListing ftm = new frmTeamListing();
            ftm.Show();
        }

        private void btnLeavesOverview_Click(object sender, EventArgs e)
        {
            frmLeaveListing ll = new frmLeaveListing();
            ll.Show();
        }

        private void btnConferenceHall_Click(object sender, EventArgs e)
        {
            frmConferenceListing fch = new frmConferenceListing();
            fch.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginpage fl = new frmLoginpage();
            fl.Show();
            
        }

        private void lblLr_Click(object sender, EventArgs e)
        {
            frmLeaveListing flr = new frmLeaveListing();
            flr.Show();
            
        }

        private void lblHr_Click(object sender, EventArgs e)
        {
            frmConferenceListing hr = new frmConferenceListing();
            hr.Show();
        }

        private void lblProjectCount_Click(object sender, EventArgs e)
        {
            frmProject fp = new frmProject();
            fp.Show();
        }

        private void lblDeptCnt_Click(object sender, EventArgs e)
        {
            frmDepartment fd = new frmDepartment();
            fd.Show();
        }

        private void lblDesgCnt_Click(object sender, EventArgs e)
        {
            frmDesignation fdep = new frmDesignation();
            fdep.Show();
        }

         
         

    }
}
