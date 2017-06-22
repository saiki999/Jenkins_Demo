using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SimpleASP.Net_Project
{
    public partial class Registration : System.Web.UI.Page
    {

        
                protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void RegistrationButtonClick(object sender, EventArgs e)
        {

            MailMessage msg = new MailMessage( );
            
            RegisterUser();
        }

        private void RegisterUser()
        {

            string conString = "Data Source=SAIKIRAN;Initial Catalog=SaikiranTest; Integrated Security= True";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string querystring = "Insert into RegistrationDetails(Fname,Lname,PhoneNumber,City,ZipCode,UserName,Password) values ('" + this.TextBox1.Text + "','" + this.TextBox2.Text
                + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + "','" + this.TextBox5.Text + "','" + this.TextBox6.Text + "','" + this.TextBox7.Text + "')";

            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Succesfully Inserted Data");
        }
    }
}