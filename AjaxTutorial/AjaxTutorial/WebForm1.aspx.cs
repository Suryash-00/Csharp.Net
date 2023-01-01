using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxTutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]     // used to handle ajax request
        public static string getData(string uname, string surname)
        {
            Thread.Sleep(3000);
            return "Your name is: " + uname + "and your surname is: " + surname;
        }
    }
}