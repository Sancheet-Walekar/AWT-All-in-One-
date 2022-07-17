using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Birthday_Calender
{
    public partial class DisplayCal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cal1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Cal1_DayRender(object sender, DayRenderEventArgs e)
        {
            //Fetch Day
            DateTime temp = e.Day.Date;
            if(temp.Day == 4 && temp.Month == 7)
            {
                Label l1 = new Label();
                l1.Text = "<BR><br> It's OM's Birthday <br><BR> ";
                l1.ForeColor = Color.Blue;
                Font f1 = new Font("Monotype Corsiva", 20, FontStyle.Regular);
                e.Cell.Controls.Add(l1);
                System.Web.UI.WebControls.Image i1 = new System.Web.UI.WebControls.Image();
                i1.ImageUrl = @"~\images\om.jpg";
                i1.Width = 100;
                i1.Height = 100;
                e.Cell.Controls.Add(i1);
            }
            if (temp.Day == 11 && temp.Month == 8)
            {
                Label l1 = new Label();
                l1.Text = "<BR><br> It's Chris Hemsworth's Birthday <br><BR> ";
                l1.ForeColor = Color.Blue;
                Font f1 = new Font("Monotype Corsiva", 20, FontStyle.Regular);
                e.Cell.Controls.Add(l1);
                System.Web.UI.WebControls.Image i1 = new System.Web.UI.WebControls.Image();
                i1.ImageUrl = @"~\images\chris.jpg";
                i1.Width = 100;
                i1.Height = 100;
                e.Cell.Controls.Add(i1);
            }
        }
    }
}