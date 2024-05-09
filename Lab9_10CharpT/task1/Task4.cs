using System;

namespace Lab9_10CharpT.task1
{
    internal class Task4
    {
        public string Result { get; private set; }

        public void Task(int n, int m)
        {
            try
            {
                DateTime start = new DateTime(1990, 1, 1);
                DateTime current = start.AddDays(n).AddMonths(m);
                Result = current.ToString("MMMM");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException: " + e.Message);
                throw;
            }
        }
    }
}
