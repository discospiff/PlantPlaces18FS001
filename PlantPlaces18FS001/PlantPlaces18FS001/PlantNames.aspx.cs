using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class PlantNames : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // throw away anything it has already started to write.
            Response.Clear();
            // change the content type, so the browser knows it's JSON
            Response.ContentType = "application/json; charset=utf-8";

            // get a list of plants
            List<Plant> plants = getPlants();

            // change the list of plants to a JSON stream.
            string plantJson = JsonConvert.SerializeObject(plants);

            // write our stuff!
            Response.Write(plantJson);
            // we're all done!
            Response.End();
            
        }

        private List<Plant> getPlants()
        {
            // create a collection of plants.
            List<Plant> allPlants = new List<Plant>();

            Plant tulipTree = new Plant();
            tulipTree.Genus = "Liriodendron";
            tulipTree.Species = "tulipiferia";
            tulipTree.Common = "Tulip Tree";
            allPlants.Add(tulipTree);

            Plant rose = new Plant();
            rose.Genus = "Rosa";
            rose.Species = "spp.";
            rose.Cultivar = "Princess Diana";
            rose.Common = "Princess Diana Rose";

            allPlants.Add(rose);

            return allPlants;
        }
    }
}