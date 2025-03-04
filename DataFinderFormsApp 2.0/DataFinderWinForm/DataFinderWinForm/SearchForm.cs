using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace DataFinderWinForm
{
    public partial class SearchForm : Form
    {
        private List<SearchItem> loadedItems;
        private Dictionary<string, string> transactionCodes = new Dictionary<string, string>();

        public SearchForm()
        {
            InitializeComponent();
            PopulateTransactionCodes();
        }

        private void PopulateTransactionCodes()
        {
            transactionCodes["0101"] = "LOGIN";
            transactionCodes["0106"] = "MERCH_RET1";
            transactionCodes["0109"] = "USERP_PRIV";
            transactionCodes["0110"] = "LOGOUT";
            transactionCodes["0202"] = "MERCH_RET";
            transactionCodes["0207"] = "INST_RET";
            transactionCodes["0215"] = "SUPP_CARD_LIST";
            transactionCodes["0302"] = "USER_RET";
            transactionCodes["0501"] = "BILL_CREATE";
            transactionCodes["0505"] = "BILL_LIST";
            transactionCodes["0705"] = "LIST_REPORT";
            transactionCodes["0710"] = "ALL_REP_ZIP";
            transactionCodes["0802"] = "ROLES_RET";
            transactionCodes["1001"] = "APPROVED";
            transactionCodes["1002"] = "APPROVED_DETAILS";
            transactionCodes["1005"] = "PENDING_APPROVED_LIST";
            transactionCodes["1011"] = "APPROVED_LIST";
            transactionCodes["1012"] = "REJECTED_LIST";
            transactionCodes["1013"] = "MY_PENDING_APPROVED_LIST";


            cmbTransactionCode.Items.Clear();
            foreach (var entry in transactionCodes)
            {
                cmbTransactionCode.Items.Add($"{entry.Key} = {entry.Value}");
            }
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    loadedItems = await ProcessFileAsync(filePath);
                    MessageBox.Show($"{loadedItems.Count} items loaded.");
                }
            }
        }

        private async Task<List<SearchItem>> ProcessFileAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                List<SearchItem> items = new List<SearchItem>();
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string date = line.Substring(16, 8);
                        string time = line.Substring(1, 6);
                        string transactionCode = line.Substring(12, 4);
                        string name = line.Substring(20, 37).Trim();
                        string data = line.Substring(52).Trim();

                        items.Add(new SearchItem(date, time, transactionCode, name, data));
                    }
                }
                return items;
            });
        }

        private List<SearchItem> FilterItems(List<SearchItem> items)
        {
            string selectedTransaction = cmbTransactionCode.SelectedItem?.ToString()?.Split('=')[0].Trim();

            return items.Where(item =>
                (string.IsNullOrEmpty(selectedTransaction) || item.TransactionCode == selectedTransaction) &&
                (string.IsNullOrEmpty(txtDate.Text) || item.Date.Contains(txtDate.Text)) &&
                (string.IsNullOrEmpty(txtTime.Text) || item.Time.Contains(txtTime.Text)) &&
                (string.IsNullOrEmpty(txtName.Text) || item.Name.Contains(txtName.Text)) &&
                (string.IsNullOrEmpty(txtData.Text) || item.Data.Contains(txtData.Text))
            ).ToList();
        }

        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        private void ToggleDarkMode()
        {
            bool isDarkMode = this.BackColor == Color.FromArgb(45, 45, 48);
            if (isDarkMode)
            {
                this.BackColor = Color.White;
                foreach (Control control in Controls)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                foreach (Control control in Controls)
                {
                    control.BackColor = Color.FromArgb(45, 45, 48);
                    control.ForeColor = Color.White;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (loadedItems != null && loadedItems.Count > 0)
            {
                var filteredItems = FilterItems(loadedItems);

                if (filteredItems.Count == 0)
                {
                    MessageBox.Show("No items match the search criteria.");
                }
                else
                {
                    MessageBox.Show($"{filteredItems.Count} items match the search criteria.");
                }

                OutputForm outputForm = new OutputForm(filteredItems);
                outputForm.Show();
            }
            else
            {
                MessageBox.Show("No data to search. Please load a file first.");
            }
        }
    }
}
