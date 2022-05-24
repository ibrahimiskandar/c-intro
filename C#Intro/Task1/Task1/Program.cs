using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 45, 67, 13,99 ,13,13,55,31};


            for (int i = 0; i <arr.Length; i++)
            {
                int number = arr[i];

                int sum = 0;
                while (number > 0)
                {
                    int module = number % 10;
                    sum = sum + module;
                    number = number / 10;
                }

                if (sum < 10)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
