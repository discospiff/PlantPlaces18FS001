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
            // get the data the user entered.
            String miles = TxtMiles.Text;

            // convert it from string to number.
            int mileage  = Convert.ToInt32(miles);

            using (var webClient = new WebClient())
            {
                String rawData =
                    webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w2ka-rfbi.json");

                List<Vehicle> cityVehicles = JsonConvert.DeserializeObject<List<Vehicle>>(rawData);

                List<Vehicle> highMileageVehicles = new List<Vehicle>();

                foreach (Vehicle veh in cityVehicles)
                {
                    if (veh.Odometer > mileage)
                    {
                        highMileageVehicles.Add(veh);

                    }
                }

                

                int i = 1 + 1;
                //  LblJSONCount.Text = "" + plantCollection.Plants.Count;
                LblNumberOfVehicles.Text = Convert.ToString(highMileageVehicles.Count);

            }

            
        }


    }
}