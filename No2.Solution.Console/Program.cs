
namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank");
            bank.Register(stock);

            var broker = new Broker("Broker");
            broker.Register(stock);

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
