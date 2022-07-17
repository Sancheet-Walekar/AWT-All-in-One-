using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class VisitCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnincrement_Click(object sender, EventArgs e)
        {
            if(Session["cntr"]==null)
            {
                lblvisit.Text = "This is your First Visit.";
                int cnt = 1;
                Session["cntr"] = cnt.ToString();
            }
            else
            {
                int cnt = int.Parse(Session["cntr"].ToString());
                cnt++;
                lblvisit.Text = "This is visit no: " + cnt;
                Session["cntr"] = cnt.ToString();
            }
        }
    }
}