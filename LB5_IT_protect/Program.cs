using System;

namespace LB5_IT_protect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности, n.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new();
            for (int q = 0; q < array.Length; q++)
            {
                array[q] = rand.Next(-100, 100);
            }
            Console.WriteLine("Изначальная последовательность:");
            foreach (int q in array)
            {
                Console.Write(q + " ");
            }
            Console.WriteLine();

            int temp;
            for (int j = n - 1; j > 0; j--)
            {
                if (array[j] < array[j - 1])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }

            Console.WriteLine("Полученная последовательность:");
            foreach (int q in array)
            {
                Console.Write(q + " ");
            }
            Console.WriteLine();
        }
    }
}