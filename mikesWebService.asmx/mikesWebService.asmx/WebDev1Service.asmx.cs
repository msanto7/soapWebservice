using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace mikesWebService.asmx
{
    /// <summary>
    /// Summary description for WebDev1Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]



    public class WebDev1Service : System.Web.Services.WebService
    {

        // simple service call to return a string (esentially a 'hello world' example)
        [WebMethod]
        public string BikesStudioService()  
        {
            return "From BikesOnRails to BikesStudio. SOAP Example.";

        }

        [WebMethod]
        public int DesiredAmountOfBikes(List<int> numBikes)
        {
            int sum = 0;
            foreach (int bike in numBikes)
            {
                sum = sum + numBikes[bike];
            }
            return sum;
        }


    } // Ends Web Service Class 

}
