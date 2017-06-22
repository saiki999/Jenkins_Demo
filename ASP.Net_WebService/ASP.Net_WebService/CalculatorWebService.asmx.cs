using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



//Web Services use HTTP protocol to transfer(send/receive) messages.
// Messaging Protocol is SOAP(Simple Object Access Protocol ), msgs are in XML Format


namespace ASP.Net_WebService
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/saikiran/webservices")] // uniquely identifies webservice
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        // need to decorate with web method attribute for this to be exposed to client.

        [WebMethod(EnableSession=true)] //Enable Session
        

            //Want to display all the recent calculation done using this Web Service using Session Object 

        public int Add(int a, int b)
        {

            List<String> calculations; //dclare list of string 

            if (Session["Calculations"] == null)
            {

                calculations = new List<string>();//creating new instance of String List
            }


            else{
            
            calculations= (List<String>)Session["Calculations"]; //Type Casting to List String
            }

            string strRecentCalculations= a.ToString()+ "+" + b.ToString()+ "=" + (a+b).ToString();
            calculations.Add(strRecentCalculations);

            Session["Calculations"] = calculations;
            return a+b;
            
        }

        [WebMethod(EnableSession=true)]
                public List<string> GetCalculations()
        {

            if (Session["Calculations"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("No Calculations are performed");
                return calculations;
                          
            }

            else {
                return (List<string>)Session["Calculations"];
                
            }
        
        }
    }
}
