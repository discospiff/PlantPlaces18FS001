using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class VehicleTravel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                String rawData =
                    webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w2ka-rfbi.json");

                List<Vehicle> cityVehicles = JsonConvert.DeserializeObject<List<Vehicle>>(rawData);

                int i = 1 + 1;
               //  LblJSONCount.Text = "" + plantCollection.Plants.Count;
            }

            
        }
    }
}