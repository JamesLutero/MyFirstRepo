using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataFinderWinForm
{
    public partial class OutputForm : Form
    {
        private DataGridView dataGridView;

        public OutputForm(List<SearchItem> items)
        {
            InitializeComponent();
            LoadData(items);
        }

        private void LoadData(List<SearchItem> items)
        {
            // Set DataGridView DataSource to the list of SearchItems
            dataGridView.DataSource = items;
            dataGridView.Dock = DockStyle.Fill; // Makes the DataGridView fill the entire form
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 

            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1232, 768);
            this.dataGridView.TabIndex = 0;
            // 
            // OutputForm
            // 
            this.ClientSize = new System.Drawing.Size(1256, 792);
            this.Controls.Add(this.dataGridView);
            this.Name = "OutputForm";
            this.Text = "Output Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
