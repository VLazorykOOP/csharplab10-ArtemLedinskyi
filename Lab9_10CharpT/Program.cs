using System;
using Lab9_10CharpT.Task1;
using Lab9_10CharpT.task2;
namespace Lab9_10CharpT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    break;
                case 2:
                    Bull bull = new Bull();
                    Bear bear = new Bear();
                    Market market = new Market();

                    bull.WantToBuy += market.OnBuy;
                    bear.WantToSell += market.OnSell;
                    bull.Buy();
                    bear.Sell();
                    break;
            }
        }
    }
}