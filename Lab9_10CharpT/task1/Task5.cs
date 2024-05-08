using System;

namespace Lab9_10CharpT.Task1
{
    internal class Task5
    {
        public int Task(int num1, int num2)
        {
            try
            {
                checked
                {
                    return (num1 * num2) * (num1 * num2);
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
