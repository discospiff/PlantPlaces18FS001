using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class AutoCompletePlants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // what did the user type?
            string term = Request.QueryString["term"];

            Response.Clear();
            // change the content type
            Response.ContentType = "application/json; charset=utf-8";

            // our suggested data
            List<string> suggestions = new List<string>();
            suggestions.Add("Burr Oak");
            suggestions.Add("White Oak");
            suggestions.Add("Red Oak");
            suggestions.Add("Pin Oak");
            suggestions.Add("Korean Oak");
            suggestions.Add("Desert Oak");
            suggestions.Add("Oak Leaf Hydrangea");

            List<string> filteredResults = new List<string>();
            
            // filter the collection by term.
            foreach(string plant in suggestions)
            {
                if (plant.Contains(term))
                {
                    // if the plant contains the user's key presses, add it to the filtered results list.
                    filteredResults.Add(plant);
                }
            }


            // convert this list to JSON
            string responseJson = JsonConvert.SerializeObject(filteredResults);

            Response.Write(responseJson);

            // flush output
            Response.End();
        }
    }
}