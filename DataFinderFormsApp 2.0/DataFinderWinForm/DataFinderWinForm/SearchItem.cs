namespace DataFinderWinForm
{
    public class SearchItem
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string TransactionCode { get; set; }
        //public string TransactionName { get; set; } // New field
        public string Name { get; set; }
        public string Data { get; set; }

        public SearchItem(string date, string time, string transactionCode, string transactionName, string name, string data)
        {
            Date = date;
            Time = time;
            TransactionCode = transactionCode;
            //TransactionName = transactionName;
            Name = name;
            Data = data;
        }

        public SearchItem(string date, string time, string transactionCode, string name, string data)
        {
            Date = date;
            Time = time;
            TransactionCode = transactionCode;
            Name = name;
            Data = data;
        }
    }
}
