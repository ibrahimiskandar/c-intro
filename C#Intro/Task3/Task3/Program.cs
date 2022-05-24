using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16; 
            int root = 0;

            for (int i = 1; i*i <= n; i++)
            {
                if (i <= n)
                {
                    root = i;
                }
            }

            Console.WriteLine(root);
        }
    }
}
