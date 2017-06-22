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
    public partial class RegistrationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string username = DropDownList1.SelectedItem.Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            SqlConnection cn = new SqlConnection(conString);

            string queryString = "Select * from RegistrationDetails where userName='"+DropDownList1.SelectedItem.Value+"'";
          

            SqlDataAdapter da = new SqlDataAdapter(queryString, cn);

            DataSet Customer = new DataSet();

            da.Fill(Customer);

            GridView1.DataSource = Customer;
            GridView1.DataBind();


            this.TextBox1.Text=Customer.Tables.Count.ToString();



        }
    }
}