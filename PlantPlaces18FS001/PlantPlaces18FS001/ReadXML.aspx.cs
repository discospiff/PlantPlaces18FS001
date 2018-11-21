using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PlantPlaces18FS001
{
    public partial class ReadXML : System.Web.UI.Page
    {
        String fullFilePath;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // only execute this logic if the user uploaded a file.
                if (XMLFileUpload.HasFile)
                {
                    // did the user upload an XML File?
                    String allowedExtension = ".xml";
                    String fileName = XMLFileUpload.FileName;
                    String extension = System.IO.Path.GetExtension(fileName).ToLower();

                    if (allowedExtension == extension)
                    {
                        // I have a valid file, I want to save it.
                        String path = Server.MapPath("~/XML/");
                        
                        fullFilePath = path + XMLFileUpload.FileName;
                        XMLFileUpload.PostedFile.SaveAs(fullFilePath);
                        LblXMLValidation.Text = "File Uploaded";
                    }
                    else
                    {
                        LblXMLValidation.Text = "File type not permitted";
                    }


                }
            }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(fullFilePath);
            doc.SelectSingleNode("/plant/specimens/specimen[latitude>0]");
            ValidateXML();
        }

        /// <summary>
        /// Validate our XML file against the XSD
        /// </summary>
        public void ValidateXML()
        {
            // LblXMLValidation.Text = "Button pressed.";
        }
    }
}