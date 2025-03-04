using System;
using System.Windows.Forms;
using System.Drawing;

namespace DataFinderWinForm
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDate;
        private TextBox txtTime;
        private TextBox txtName;
        private TextBox txtData;
        private Button btnUpload;
        private Button btnSearch;
        private Button btnToggleDarkMode;
        private Label lblDate;
        private Label lblTime;
        private Label lblTransactionCode;
        private Label lblName;
        private Label lblData;
        private System.Windows.Forms.ComboBox cmbTransactionCode;


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
            this.cmbTransactionCode = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnToggleDarkMode = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTransactionCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTransactionCode
            // 
            this.cmbTransactionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionCode.Location = new System.Drawing.Point(20, 123);
            this.cmbTransactionCode.Name = "cmbTransactionCode";
            this.cmbTransactionCode.Size = new System.Drawing.Size(200, 21);
            this.cmbTransactionCode.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(20, 40);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 0;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(20, 80);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 20);
            this.txtTime.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 168);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(20, 208);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 20);
            this.txtData.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(150, 238);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(70, 30);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToggleDarkMode
            // 
            this.btnToggleDarkMode.Location = new System.Drawing.Point(80, 268);
            this.btnToggleDarkMode.Name = "btnToggleDarkMode";
            this.btnToggleDarkMode.Size = new System.Drawing.Size(80, 30);
            this.btnToggleDarkMode.TabIndex = 7;
            this.btnToggleDarkMode.Text = "Toggle Dark Mode";
            this.btnToggleDarkMode.Click += new System.EventHandler(this.btnToggleDarkMode_Click);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(20, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 20);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // lblTransactionCode
            // 
            this.lblTransactionCode.Location = new System.Drawing.Point(20, 100);
            this.lblTransactionCode.Name = "lblTransactionCode";
            this.lblTransactionCode.Size = new System.Drawing.Size(100, 20);
            this.lblTransactionCode.TabIndex = 10;
            this.lblTransactionCode.Text = "Transaction Code";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(20, 188);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 20);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // SearchForm
            // 
            this.ClientSize = new System.Drawing.Size(242, 330);
            this.Controls.Add(this.cmbTransactionCode);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnToggleDarkMode);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTransactionCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblData);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
