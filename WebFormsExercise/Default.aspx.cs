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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;

        lblNameOutput.Text = "Hello " + name;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            Label1.Text = "Checkbox is ticked!";
        } else
        {
            Label1.Text = "Checkbox isn't ticked!";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label2.Text = "You have selected " + RadioButtonList1.SelectedItem;
    }

    protected void CheckedChanged(object sender, EventArgs e)
    {
        Label3.Text = "Hello " + nameTwo.Text + " the checkbox is " + CheckBox2.Checked + " the radio button is " + RadioButton1.Checked;
       
    }

    

    
}