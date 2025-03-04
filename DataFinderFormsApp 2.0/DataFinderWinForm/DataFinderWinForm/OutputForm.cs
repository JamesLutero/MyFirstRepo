using DataFinderWinForm;
using System.Collections.Generic;
using System.Windows.Forms;

public class OutputForm : Form
{
    private List<SearchItem> _items;
    private ListBox listBoxResults;

    public OutputForm(List<SearchItem> items)
    {
        _items = items;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        listBoxResults = new ListBox();
        listBoxResults.DataSource = _items;
        listBoxResults.DisplayMember = "Name";  // Or any other property you want to display

        this.Controls.Add(listBoxResults);
        listBoxResults.Dock = DockStyle.Fill;
        this.Text = "Search Results";
    }
}
