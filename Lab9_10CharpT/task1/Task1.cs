using System;

namespace Lab9_10CharpT.task1
{
    public class Task1
    {
        public double Result { get; private set; }

        public void Task(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            try
            {
                if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0 || x3 < 0 || y3 < 0)
                {
                    throw new ArgumentException("Координати не можуть бути від'ємними.");
                }

                double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

                Result = AB + AC + BC;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException: " + e.Message);
                throw;
            }
        }
    }
}
