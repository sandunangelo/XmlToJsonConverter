using System;
using System.Xml;
using Newtonsoft.Json;
using System.IO;


namespace XmlToJsonConverter
{
    public class XmlHelper
    {
        /// <summary>
        /// Validate the XML file and content from a given path to a file.
        /// </summary>
        /// <param name="filePath">Source path of the file.</param>
        /// <returns>Returns an XmlDocument object, null if invalid.</returns>
        public static XmlDocument ValidateXmlDocument(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(filePath);
            }
            catch (Exception)
            {
                doc = null;
            }
            return doc;
        }

        /// <summary>
        /// Export the XmlDocument object as a JSON file to the given destination file path.
        /// </summary>
        /// <param name="xmlDocument">Valid XmlDocument object.</param>
        /// <param name="destinationPath">Target location for the JSON file.</param>
        /// <returns>True, if exporting success.</returns>
        public static bool ExportXmlDocumentAsJsonFile(XmlDocument xmlDocument, string destinationPath)
        {
            if (xmlDocument != null)
            {
                string json = JsonConvert.SerializeXmlNode(xmlDocument);

                using (StreamWriter jsonFile = File.CreateText(destinationPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jsonFile, xmlDocument);
                }
                return true;
            }
            return false;
        }

    }
}
