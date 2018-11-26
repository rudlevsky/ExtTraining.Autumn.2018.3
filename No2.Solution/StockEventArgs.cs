using System;

namespace No2.Solution
{
    public class StockEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
