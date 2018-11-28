using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PlantPlaces18FS001
{
    /// <summary>
    /// Summary description for CommonToLatinConverter
    /// </summary>
    [WebService(Namespace = "http://plantplaces.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CommonToLatinConverter : System.Web.Services.WebService
    {

        [WebMethod]
        public string ConvertToLatinName(String commonName)
        {
            string returnValue = "HelloWorld";
            if (commonName == "Oak")
            {
                returnValue = "Quercus";
            } else if (commonName == "Maple")
            {
                returnValue = "Acer";
            } else if (commonName == "Pine")
            {
                returnValue = "Pinus";
            }
            return returnValue;
        }
    }
}
