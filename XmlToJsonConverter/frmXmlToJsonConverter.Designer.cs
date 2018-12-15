namespace XmlToJsonConverter
{
    partial class frmXmlToJsonConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.btnXmlFilePicker = new System.Windows.Forms.Button();
            this.lblXmlFilePath = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnValidateXml = new System.Windows.Forms.Button();
            this.btnExportAsJsonFile = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lnkRepositoryLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ofdSourceFile
            // 
            this.ofdSourceFile.FileName = "sample.xml";
            // 
            // btnXmlFilePicker
            // 
            this.btnXmlFilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlFilePicker.Location = new System.Drawing.Point(33, 22);
            this.btnXmlFilePicker.Name = "btnXmlFilePicker";
            this.btnXmlFilePicker.Size = new System.Drawing.Size(420, 31);
            this.btnXmlFilePicker.TabIndex = 0;
            this.btnXmlFilePicker.Text = "Select XML File";
            this.btnXmlFilePicker.UseVisualStyleBackColor = true;
            this.btnXmlFilePicker.Click += new System.EventHandler(this.btnXmlFilePicker_Click);
            // 
            // lblXmlFilePath
            // 
            this.lblXmlFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXmlFilePath.Location = new System.Drawing.Point(33, 56);
            this.lblXmlFilePath.Name = "lblXmlFilePath";
            this.lblXmlFilePath.Padding = new System.Windows.Forms.Padding(5);
            this.lblXmlFilePath.Size = new System.Drawing.Size(420, 63);
            this.lblXmlFilePath.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnValidateXml
            // 
            this.btnValidateXml.Enabled = false;
            this.btnValidateXml.Location = new System.Drawing.Point(33, 132);
            this.btnValidateXml.Name = "btnValidateXml";
            this.btnValidateXml.Size = new System.Drawing.Size(420, 37);
            this.btnValidateXml.TabIndex = 3;
            this.btnValidateXml.Text = "Validate XML File and Content";
            this.btnValidateXml.UseVisualStyleBackColor = true;
            this.btnValidateXml.Click += new System.EventHandler(this.btnValidateXml_Click);
            // 
            // btnExportAsJsonFile
            // 
            this.btnExportAsJsonFile.Enabled = false;
            this.btnExportAsJsonFile.Location = new System.Drawing.Point(33, 175);
            this.btnExportAsJsonFile.Name = "btnExportAsJsonFile";
            this.btnExportAsJsonFile.Size = new System.Drawing.Size(420, 35);
            this.btnExportAsJsonFile.TabIndex = 4;
            this.btnExportAsJsonFile.Text = "Export As JSON File";
            this.btnExportAsJsonFile.UseVisualStyleBackColor = true;
            this.btnExportAsJsonFile.Click += new System.EventHandler(this.btnExportAsJsonFile_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(30, 248);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(129, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "By Sandun Angelo Perera";
            // 
            // lnkRepositoryLink
            // 
            this.lnkRepositoryLink.AutoSize = true;
            this.lnkRepositoryLink.Location = new System.Drawing.Point(30, 261);
            this.lnkRepositoryLink.Name = "lnkRepositoryLink";
            this.lnkRepositoryLink.Size = new System.Drawing.Size(270, 13);
            this.lnkRepositoryLink.TabIndex = 6;
            this.lnkRepositoryLink.TabStop = true;
            this.lnkRepositoryLink.Text = "https://github.com/sandunangelo/XmlToJsonConverter";
            // 
            // frmXmlToJsonConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.ControlBox = false;
            this.Controls.Add(this.lnkRepositoryLink);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnExportAsJsonFile);
            this.Controls.Add(this.btnValidateXml);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblXmlFilePath);
            this.Controls.Add(this.btnXmlFilePicker);
            this.Name = "frmXmlToJsonConverter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML to JSON Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdSourceFile;
        private System.Windows.Forms.Button btnXmlFilePicker;
        private System.Windows.Forms.Label lblXmlFilePath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnValidateXml;
        private System.Windows.Forms.Button btnExportAsJsonFile;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel lnkRepositoryLink;
    }
}

