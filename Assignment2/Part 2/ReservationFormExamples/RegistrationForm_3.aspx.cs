using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationForm_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public RegistrationInfo RegistrationInfo
    {
        get
        {
            return new RegistrationInfo
            {
                FirstName = txtFirstName.Text, // comma rather than semicolon
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                SelectedEvent = ddlEvents.SelectedValue
            };  // ended by semicolon
        }
    
    }
}