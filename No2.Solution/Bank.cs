using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
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
                e.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{e.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {e.Euro}");
        }
    }
}
