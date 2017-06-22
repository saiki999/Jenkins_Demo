using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ConsumingCalcWebServicce
{
    public partial class AddCal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();
            Label1.Text=   Convert.ToString(client.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)));
        }
    }
}