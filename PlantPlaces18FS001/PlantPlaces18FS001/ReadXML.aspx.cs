using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

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
            XmlNode node = doc.SelectSingleNode("/plant/specimens/specimen[latitude>0]");
            ValidateXML();
        }

        /// <summary>.
        /// Validate our XML file against the XSD
        /// </summary>
        public void ValidateXML()
        {
            // Declare our validation preferences.'
            XmlReaderSettings settings = new XmlReaderSettings();
            // validate with XSD
            settings.ValidationType = ValidationType.Schema;
            // a couple more validation options.
            settings.ValidationFlags |= System.Xml.Schema.XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings;

            settings.ValidationEventHandler +=
                new System.Xml.Schema.ValidationEventHandler(
                    this.ValidationEventHandler);

            XmlReader xmlReader = XmlReader.Create(fullFilePath, settings);
            try
            {
                while (xmlReader.Read())
                {

                }
                // we only get here if no exception was thrown.
                LblXMLValidation.Text = "Validation successful";
            } catch (Exception e)
            {
                // we only get here if there was a validation error.
                LblXMLValidation.Text = e.Message;
            }
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            LblXMLValidation.Text = "Validation failed.  Message = " + args.Message;
            throw new Exception("Validation failed.  Message: " + args.Message);
        }
    }
}