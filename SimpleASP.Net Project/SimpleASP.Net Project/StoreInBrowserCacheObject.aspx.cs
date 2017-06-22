using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SimpleASP.Net_Project
{
    public partial class StoreInBrowserCacheObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cString= System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            using(SqlConnection cn= new SqlConnection(cString))
            {

                if (Cache["Data"] == null)
                {
                    string qString = "Select * from RegistrationDetails";

                    SqlDataAdapter ad = new SqlDataAdapter(qString, cn);

                    DataSet ds = new DataSet();

                    ad.Fill(ds);

                    Cache["Data"] = ds;

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    TextBox1.Text = "Data is Loaded from Database";
                    Cache["Data"] = ds;
                }
                else {

                    GridView1.DataSource = (DataSet)Cache["Data"];
                    GridView1.DataBind();

                    TextBox1.Text = "Data is Loaded from Cache";
                }

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] != null)
            {

                Cache.Remove("Data");
                TextBox1.Text = "cache is cleared";
            }

            else {
                TextBox1.Text = "No cache to clear";
            
            }
        }
    }
}