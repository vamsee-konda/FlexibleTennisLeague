﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace FlexibleTennisLeague.LosAngeles
{
    public partial class Fall2009 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Status = "301 Moved Permanently";
            Response.AddHeader("Location", "http://flexibletennisleague.com/losangeles/");
        }
    }
}
