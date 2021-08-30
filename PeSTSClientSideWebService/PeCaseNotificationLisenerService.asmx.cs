using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BackgroundCheckandReports;
using System.Xml;
using System.Xml.Linq;

namespace PeSTSClientSideWebService
{
    /// <summary>
    /// Summary description for PeCaseNotificationLisenerService
    /// </summary>
    [WebService(Namespace = "http://gardaonlineservices.com/PeService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PeCaseNotificationLisenerService : System.Web.Services.WebService
    {

        [WebMethod]
        public string SychronizeCaseStatus(XmlElement report)
        {
            return "OK";
        }

        [WebMethod]
        public XElement SychronizeCaseStatus2(XElement report)
        {
            return new XElement("Result", new XElement("OK"));
        }
    }
}
