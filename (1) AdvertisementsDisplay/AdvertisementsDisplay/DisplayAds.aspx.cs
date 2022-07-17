using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdvertisementsDisplay
{
    public partial class DisplayAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            adrAdvertisements.KeywordFilter = "k2";
        }
    }
}