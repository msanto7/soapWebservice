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
        public String DesiredAmountOfBikes(int height)
        {
            if (height <= 63)
            {
                return "Small";
            }
            else if (height > 63 && height <= 67)
            {
                return "Medium";
            }
            else if (height > 67 && height <= 71)
            {
                return "Large";
            }
            else
            {
                return "Extra Large";
            }
        }


    } // Ends Web Service Class 

}
