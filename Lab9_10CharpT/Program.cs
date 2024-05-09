using System;
using Lab9_10CharpT.task1;
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
                    
                    Console.WriteLine("Enter x1");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y1");
                    int y1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter x2");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y2");
                    int y2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter x3");
                    int x3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y3");
                    int y3 = int.Parse(Console.ReadLine());
                    Task1 task1 = new Task1();
                    task1.Task(x1, y1, x2, y2, x3, y3);
                    Console.WriteLine(task1.Result);
                    Task2 task2 = new Task2();
                    Console.WriteLine("Enter number");
                    int num = int.Parse(Console.ReadLine());
                    task2.Task(num);
                    Console.WriteLine(task2.Result);
                    Task3 task3 = new Task3();
                    Console.WriteLine("Enter x : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y : ");
                    int y = int.Parse(Console.ReadLine());
                    string result =task3.Task(x, y);
                    Console.WriteLine(result);
                    Task4 task4 = new Task4();
                    Console.WriteLine("Enter day : ");
                    int day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter mounth : ");
                    int mounth = int.Parse(Console.ReadLine());
                    task4.Task(day, mounth);    
                    Console.WriteLine(task4.Result);
                    Task5 task5 = new Task5();
                    Console.WriteLine("Enter first number");
                    int firstnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int secondnumber = int.Parse(Console.ReadLine());
                    task5.Task(firstnumber, secondnumber);
                    Console.WriteLine(task5.Result);
                    Task6 task6 = new Task6();
                    Console.WriteLine("Enter x : ");
                    double _x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y : ");
                    double _y = double.Parse(Console.ReadLine());
                    task6.Task(_x, _y);
                    Console.WriteLine(task6.Result);
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