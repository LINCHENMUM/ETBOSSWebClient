using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETBOSSWebClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ETBOSSService.ETBOSSServiceClient client = new ETBOSSService.ETBOSSServiceClient("BasicHttpBinding_IETBOSSService");
            Label1.Text=client.GetCustomerName(TextBox1.Text);
        }
    }
}