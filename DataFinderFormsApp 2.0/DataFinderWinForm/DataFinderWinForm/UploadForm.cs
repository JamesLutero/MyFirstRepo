using System;
using System.IO;
using System.Windows.Forms;

namespace DataFinderWinForm
{
    public partial class UploadForm : Form
    {
        public UploadForm(string filePath, string fileContent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblFileName.Text = "Selected File: " + Path.GetFileName(filePath);
            txtFileContent.Text = fileContent;
        }
    }
}
