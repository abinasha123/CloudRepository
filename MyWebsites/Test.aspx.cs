using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace MyWebsites
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Please click the button";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Button is clicked1";
           System.Diagnostics.Trace.TraceError("Working");
            System.Diagnostics.Trace.TraceError("Slow response - database01");



        }
    }
}