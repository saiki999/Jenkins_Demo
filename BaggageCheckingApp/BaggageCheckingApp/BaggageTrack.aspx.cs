using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace BaggageCheckingApp
{
    public partial class BaggageTrack : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        public void getDetails(int bagnum)
        {
         

            string con = ConfigurationManager.ConnectionStrings["MyCon"].ToString();
            
                using (SqlConnection cn = new SqlConnection(con))
                {

                    cn.Open();

                    SqlCommand cmd = new SqlCommand("sp_getDetails", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter bagno = cmd.Parameters.Add("@bagNumber", bagnum);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblbagavail.Visible = false;
                        Panel2.Visible = true;
                        bagtagnumber.Text = dr[0].ToString();
                        lastscandate.Text = dr[1].ToString();
                        bagstatus.Text = dr[2].ToString();
                        airline.Text = dr[3].ToString();
                        flightnumber.Text = dr[4].ToString();
                        departuretime.Text = dr[5].ToString();
                        departureairport.Text = dr[6].ToString();
                        passengername.Text = dr[7].ToString() + dr[8].ToString();
                        lblship.Text = dr[9].ToString();
                        lblcabin.Text = dr[10].ToString();
                        returndate.Text = dr[11].ToString();

                    }

                    else
                    {
                        Panel2.Visible = false;
                        lblbagavail.Visible = true;
                        lblbagavail.Text = "Bag not yet scanned";
                    }


             }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            

                //int flightNumber = Convert.ToInt32(Ship.SelectedItem);
                //string departureDate = Convert.ToString(calReturndate.SelectedDate);
                //string lastName = LastName.Text;
                //string cabin = Cabin.Text;
                Panel2.Visible = false;
                Label1.Visible = false;

                string con = ConfigurationManager.ConnectionStrings["MyCon"].ToString();

                using (SqlConnection cn = new SqlConnection(con))
                {
                    cn.Open();


                    SqlCommand cmd = new SqlCommand("sp_CheckDetails", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter lname = cmd.Parameters.Add("@Last_Name", LastName.Text);
                    lname.Direction = ParameterDirection.Input;
                    SqlParameter FNumber = cmd.Parameters.Add("@flight_Number", Ship.SelectedValue);
                    FNumber.Direction = ParameterDirection.Input;
                    SqlParameter DepDate = cmd.Parameters.Add("@Departure_Date", calReturndate.SelectedDate);
                    DepDate.Direction = ParameterDirection.Input;
                    SqlParameter CabinNumber = cmd.Parameters.Add("@Cabin_Number", Cabin.Text);
                    CabinNumber.Direction = ParameterDirection.Input;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Label1.Visible = false;
                        //Label1.Text = "Data Valid";
                        lblbaglist.Visible = true;
                        lblbaglist.Text = "Below are List of Bags Available for:" + LastName.Text;
                        Panel1.Visible = true;
                        int pnr = (int)dr[0];

                        Session["pnr"] = pnr;


                    }

                    else
                    {
                        Panel1.Visible = false;
                        Label1.Visible = true;
                        Label1.Text = "Please Enter Vaid Data";


                    }

                }


            }
        

        
#region linkbutton
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow.Cells[1].Text != "")
            {
                int bagNo = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

                getDetails(bagNo);


            }
            else
            {



            }
        }
#endregion

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    GridViewRow row = GridView1.SelectedRow;

            
        //                  int bagno = Convert.ToInt32((row.Cells[0].Text));

        //                  getDetails(bagno);

        //}
    }
}