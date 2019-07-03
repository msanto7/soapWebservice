using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Xml;

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


        public static HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:56405/WebService1.asmx?op=HelloWorld");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }



        
        [WebMethod]
        public String DesiredAmountOfBikes(int height)
        {

            /*
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                  <soap:Body>
                    <HelloWorld xmlns=""http://tempuri.org/"" />
                  </soap:Body>
                </soap:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    Console.WriteLine(soapResult);
                }
            }         */   


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
