using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Sort
{
    class Program
    {
        private static void Quick_Sort(int[] dizi, int sol, int sag)
        {
            if (sol < sag)
            {
                int pivot = Partition(dizi, sol, sag);
                if (pivot > 1)
                {
                    Quick_Sort(dizi, sol, pivot - 1);
                }
                if (pivot + 1 < sag)
                {
                    Quick_Sort(dizi, pivot + 1, sag);
                }
            }
        }

        private static int Partition(int[] dizi, int sol, int sag)
        {
            int pivot = dizi[sol];
            while (true)
            {
                while (dizi[sol] < pivot)
                {
                    sol++;
                }
                while (dizi[sag] > pivot)
                {
                    sag--;
                }
                if (sol < sag)
                {
                    if (dizi[sol] == dizi[sag]) return sag;
                    int temp = dizi[sol];
                    dizi[sol] = dizi[sag];
                    dizi[sag] = temp;
                }
                else
                {
                    return sag;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Orjinal Dizi: ");
            foreach (var item in dizi)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(dizi, 0, dizi.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sıralanmış Dizi: ");

            foreach (var item in dizi)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}