using System;

namespace Lab9_10CharpT.task1
{
    internal class Task5
    {
        public int Result { get; private set; }

        public void Task(int num1, int num2)
        {
            try
            {
                checked
                {
                    Result = (num1 * num2) * (num1 * num2);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OverflowException: " + e.Message);
                throw;
            }
        }
    }
}
