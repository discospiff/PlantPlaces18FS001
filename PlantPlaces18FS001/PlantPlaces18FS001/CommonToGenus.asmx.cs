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
    /// Summary description for CommonToGenus
    /// </summary>
    [WebService(Namespace = "http://www.plantplaces.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CommonToGenus : System.Web.Services.WebService
    {

        [WebMethod]
        public string ConvertCommonToGenus(String common)
        {
            // default return value.
            string returnValue = "No genus found";

            // collection of plants from JSON
            PlantCollection plantCollection;

            // Dictionary of genera and count
            IDictionary<String, Int32> generaCount = new Dictionary<String, Int32>();

            // read the raw JSON data.
            using(var webClient = new WebClient())
            {
                string rawData = webClient.DownloadString("http://www.plantplaces.com/perl/mobile/viewplantsjson.pl?Combined_Name=" + common);

                plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawData);
            }

            // accumulate genera counts
            foreach(Plant plant in plantCollection.Plants)
            {
                if (generaCount.ContainsKey(plant.Genus))
                {
                    // get current count of genus
                    int currentCount = generaCount[plant.Genus];
                    // add one
                    currentCount++;
                    // store new value.
                    generaCount[plant.Genus] = currentCount;
                }
                else
                {
                    // genus does not exist; add it with a default count of "1"
                    generaCount.Add(plant.Genus, 1);
                }
            }

            int highWaterMark = 0;

            // find the most common genus
            foreach(string genus in generaCount.Keys)
            {
                int currentfrequency = generaCount[genus];

                if (currentfrequency > highWaterMark)
                {
                    // elect a new genus 
                    returnValue = genus;

                    highWaterMark = currentfrequency;
                }

            }


            return returnValue;
        }
    }
}
