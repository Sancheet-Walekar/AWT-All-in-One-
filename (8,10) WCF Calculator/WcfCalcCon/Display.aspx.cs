using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfCalcCon
{
    public partial class Display : System.Web.UI.Page
    {
        ServiceReference1.Service1Client c1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtno1.Text);
            int num2 = int.Parse(txtno2.Text);
            lblresult.Text = c1.Add(num1, num2).ToString();
        }

        protected void btnsubtract_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtno1.Text);
            int num2 = int.Parse(txtno2.Text);
            lblresult.Text = c1.Subtract(num1, num2).ToString();
        }

        protected void btnmultiply_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtno1.Text);
            int num2 = int.Parse(txtno2.Text);
            lblresult.Text = c1.Multiply(num1, num2).ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtno1.Text);
            int num2 = int.Parse(txtno2.Text);
            lblresult.Text = c1.Divide(num1, num2).ToString();
        }
    }
}