using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SimpleASP.Net_Project
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            LoginValidate();
        }

        protected void LoginValidate() {

   

            //uisng connection string from web.config file
           string conStringFromWebConfig = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            //string conString = "Data Source=SAIKIRAN;Initial Catalog=SaikiranTest; Integrated Security= True";
           string conString = conStringFromWebConfig;
            
            string queryString = "Select * from RegistrationDetails where UserName='"+TextBox1.Text +"' and Password='"+TextBox2.Text +"'";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString,con);
            SqlDataReader rdr = cmd.ExecuteReader();//new SqlDataReader();   //Data Reader

            //rdr=
            if (rdr.HasRows)
            {
                Response.Redirect("RegistrationDetails.aspx");
            }
            else{

                this.TextBox2.Text = "Invalid data";

            }
            
            
        }
    }
}