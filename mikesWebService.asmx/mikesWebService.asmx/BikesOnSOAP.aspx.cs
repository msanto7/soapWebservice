using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mikesWebService.asmx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            WebDev1Service webService = new WebDev1Service();
            // List<int> lstIntegers = new List<int> { 5, 6, 7 };
            int height = Int32.Parse(heightInput.Text);

            webServiceOutput.Text = "Recommended Bike Size: " + webService.DesiredAmountOfBikes(height).ToString();

        }


    }
}