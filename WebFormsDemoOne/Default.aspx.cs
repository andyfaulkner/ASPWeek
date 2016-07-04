using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime myDate = new DateTime();

        myDate = DateTime.Now;

        Label1.Text = "The current date and time is " + myDate;
    }
}