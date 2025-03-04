using System.Windows.Forms;

namespace DataFinderWinForm
{
    partial class UploadForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(20, 20);
            this.lblFileName.Size = new System.Drawing.Size(100, 15);
            this.lblFileName.Text = "Selected File: None";

            
            this.txtFileContent.Location = new System.Drawing.Point(20, 50);
            this.txtFileContent.Size = new System.Drawing.Size(400, 200);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.ScrollBars = ScrollBars.Vertical;
            this.txtFileContent.ReadOnly = true;

            
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileContent);
            this.Text = "Uploaded File";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileContent;
    }
}
