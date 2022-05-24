using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 30;
            int count = 0;
            for (int i =n+1; i < m; i++)
            {
                if (i % 15 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
