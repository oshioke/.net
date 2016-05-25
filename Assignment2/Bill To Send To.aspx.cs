using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bill_To_Send_To : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {


    }

    // if the check box is checked 
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked) // if checked auto post back the same information from bill to section
         {
             txtShipFirstName.Text = txtFirstName.Text;
             txtShipLastName.Text = txtLastName.Text;
             txtShipStreet.Text = txtStreet.Text;
             txtShipCity.Text = txtCity.Text;
             ddlShipState.Text = ddlState.Text;
             txtShipZip.Text = txtZip.Text;

         }

        else //  if the check box isnt checked leave the text boxes blank
        {
            txtShipFirstName.Text = "";
            txtShipLastName.Text = "";
            txtShipStreet.Text = "";
            txtShipCity.Text = "";
            ddlShipState.Text = ""; ;
            txtShipZip.Text = "";


        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {



    }
}
