using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fix_Sys_V2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            th.ac.psu.passport.Authentication authen = new th.ac.psu.passport.Authentication();
           
            int i;
            string[] Data = new string[99];
            i = 0;
            if (authen.Authenticate(this.ID.Text, this.Pass.Text))
            {
                foreach (string b in authen.GetUserDetails(this.ID.Text, this.Pass.Text))
                {
                    Data[i]= b;
                    i++;
                    //Response.Write((b + "<br>"));
                    Response.Redirect ("/Home/Index");

                }

            }
        }
    }
}