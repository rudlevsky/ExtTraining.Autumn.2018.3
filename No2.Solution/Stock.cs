using System;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockEventArgs> OnChange = delegate { };

        private StockEventArgs stocksInfo;

        public Stock()
        {
            stocksInfo = new StockEventArgs();
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnChange?.Invoke(this, stocksInfo);
        }
    }
}
