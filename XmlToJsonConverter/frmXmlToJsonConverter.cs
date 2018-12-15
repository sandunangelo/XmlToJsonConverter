using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XmlToJsonConverter
{
    public partial class frmXmlToJsonConverter : Form
    {
        private string sourceFilePath = string.Empty;
        private string destinationFilePath = string.Empty;
        private XmlDocument xmlDocument = null;

        public frmXmlToJsonConverter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Select the XML file from the file system, and enable next steps in the UI.
        /// </summary>
        private void btnXmlFilePicker_Click(object sender, EventArgs e)
        {
            var dres = ofdSourceFile.ShowDialog();

            if (dres == DialogResult.OK)
            {
                lblXmlFilePath.Text = ofdSourceFile.FileName;
                sourceFilePath = ofdSourceFile.FileName;
                destinationFilePath = Path.ChangeExtension(Path.GetFullPath(sourceFilePath), ".json");

                btnValidateXml.Enabled = !string.IsNullOrWhiteSpace(sourceFilePath);
            }

            btnExportAsJsonFile.Enabled = xmlDocument != null;
        }

        /// <summary>
        /// Validate the selected XML file and its content, and enable next step in the UI.
        /// </summary>
        private void btnValidateXml_Click(object sender, EventArgs e)
        {
            xmlDocument = XmlHelper.ValidateXmlDocument(sourceFilePath);

            if (xmlDocument != null)
            {
                MessageBox.Show("Valid XML document found.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExportAsJsonFile.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid XML document found, check the XML file content and extension before trying again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnExportAsJsonFile.Enabled = false;
            }
        }

        /// <summary>
        /// Export the validated XML content as a JSON file to the same directory.
        /// </summary>
        private void btnExportAsJsonFile_Click(object sender, EventArgs e)
        {
            if (XmlHelper.ExportXmlDocumentAsJsonFile(xmlDocument, destinationFilePath))
            {
                MessageBox.Show("Xml file exported as a Json file succefulll.", "Export completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to exported Xml file as a Json file, check the folder permission.", "Export failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Terminate the application from execution.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
