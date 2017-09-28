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

        protected void GetEmployee_Click(object sender, EventArgs e)
        {
            ETBOSSService.ETBOSSServiceClient client = new ETBOSSService.ETBOSSServiceClient("BasicHttpBinding_IETBOSSService");
            ETBOSSService.Employee employee=client.GetEmployee(Convert.ToInt32(txtID.Text));
            txtID.Text = employee.Id.ToString();
            txtName.Text = employee.Name;
            txtDob.Text = employee.Dob.ToString();

            Label1.Text = "Get employee done.";

        }

        protected void SaveEmployee_Click(object sender, EventArgs e)
        {
            ETBOSSService.ETBOSSServiceClient client = new ETBOSSService.ETBOSSServiceClient("BasicHttpBinding_IETBOSSService");



            ETBOSSService.Employee employee = new ETBOSSService.Employee();
            employee.Id = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            employee.Dob = Convert.ToDateTime(txtDob.Text);

            client.SaveEmployee(employee);

            Label1.Text = "Save employee done.";
        }
    }
}