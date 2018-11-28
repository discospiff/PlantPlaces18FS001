using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class AutoCompletePlantNames : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the letters that the user typed (if any).
            String term = Request.QueryString["term"];

            Response.Clear();
            // change the content type, so the browser knows it's JSON
            Response.ContentType = "application/json; charset=utf-8";

            List<String> plantSuggestions = new List<String>();
            plantSuggestions.Add("White Oak");
            plantSuggestions.Add("Burr Oak");
            plantSuggestions.Add("Red Oak");
            plantSuggestions.Add("Pin Oak");
            plantSuggestions.Add("Holly Oak");
            plantSuggestions.Add("Cherry Oak");
            plantSuggestions.Add("Korean Oak");

            List<String> matchedPlants = new List<String>();

            // iterate over these options, and show only ones that contain the user's text.
            foreach(String plant in plantSuggestions)
            {
                if (plant.Contains(term))
                {
                    matchedPlants.Add(plant);
                }
            }

            // change the list of plants to a JSON stream.
            string plantJson = JsonConvert.SerializeObject(matchedPlants);

            // write our stuff!
            Response.Write(plantJson);
            // we're all done!
            Response.End();
        }
    }
}