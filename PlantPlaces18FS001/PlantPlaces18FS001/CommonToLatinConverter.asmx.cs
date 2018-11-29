using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            // declare variable plant collection.
            PlantCollection plantCollection;

            string returnValue = "HelloWorld";
            using (var webClient = new WebClient())
            {
                String rawData =
                    webClient.DownloadString("http://www.plantplaces.com/perl/mobile/viewplantsjson.pl");

                // assign the variable plant collection.
                 plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawData);

             
            }
            // get the plant collection returned.
            List<Plant> allPlants = plantCollection.Plants;
            // shake hands with each plant.
            foreach(Plant plant in allPlants)
            {
                // ask this plant if it contains our common name.
                if (plant.Common.Contains(commonName))
                {
                    returnValue = plant.Genus;
                }

            }
            return returnValue;
        }
    }
}
