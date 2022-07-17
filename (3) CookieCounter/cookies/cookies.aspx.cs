using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie c1 = new HttpCookie("c1");
            //Response.Cookies.Add("c1");
            HttpCookieCollection cookies;
            cookies = Request.Cookies;
            int cnt = cookies.Count;
            if(cookies.Count == 0)
            {
                lblvisit.Text = "This is your first visit!";
                cnt = 1;
                Response.Cookies.Add(c1);
            }
            else if (cookies.Count > 0)
            {
                //cookies = Request.Cookies;
                //if(cookies.Count > 0)
                //{
                cnt++;
                lblvisit.Text = "This is visit no: " + cnt;
                    //Response.Cookies.Add(c1);
                //}
            }
            cookies = Request.Cookies;
        }
    }
}