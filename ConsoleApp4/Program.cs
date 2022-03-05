using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = { 8, 4, -2, 3,-6 , 5, 9 };
            int min = ededler[0];
            for (int i = 0; i < ededler.Length; i++)
            {
                if (ededler[i]<min)
                {
                    min = ededler[i];
                }
            }
            Console.WriteLine(min);

        }
    }
}
