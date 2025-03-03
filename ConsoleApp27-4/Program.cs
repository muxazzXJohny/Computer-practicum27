using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] Omas = { 1, 10, 16, 5, 21, 3 }; 
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < Omas.Length; i++)
            {
                if (Omas[i] < Omas[minIndex])
                {
                    minIndex = i;
                }
                if (Omas[i] > Omas[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int count = Math.Abs(maxIndex - minIndex) - 1;
            Console.WriteLine($"Количество элементов между минимальным и максимальным:{count}");
            Console.ReadLine();
        }
    }
}
    

