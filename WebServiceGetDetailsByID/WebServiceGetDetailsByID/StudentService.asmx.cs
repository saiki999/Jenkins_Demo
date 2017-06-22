using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebServiceGetDetailsByID
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

            [WebMethod]
        public StudentDetails GetStudentById(int id)
        {

            String cs = ConfigurationManager.ConnectionStrings["SQLconnection"].ToString();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetDetailsById",con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par= new SqlParameter("@id",id);  // as sp expects ID parameter
                cmd.Parameters.Add(par); //associating parameters to command object

                StudentDetails student = new StudentDetails();//creating student object
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader return SQL Data reader object
                while (dr.Read())
                {
                    student.Id = (int)dr["Id"]; //name of column should match with name in database
                    student.Fname=dr["Fname"].ToString();
                    student.Lname = dr["Lname"].ToString();
                                   
                }


                return student;
          }

    
        }
    }
}
