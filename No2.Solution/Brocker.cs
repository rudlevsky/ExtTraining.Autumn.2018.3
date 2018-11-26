using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            stock.OnChange += Update;
        }

        public void UnRegister(Stock stock)
        {
            stock.OnChange -= Update;
        }

        public void Update(object obj, StockEventArgs e)
        {
            Console.WriteLine(
                e.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {e.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {e.USD}");
        }
    }
}
