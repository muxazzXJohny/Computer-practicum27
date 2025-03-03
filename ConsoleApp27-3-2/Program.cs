using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Omas = { 1, 5, 10, 32, 16, 15 };            
            int minElement = Omas[0];
            int minIndex = 0;

            for (int i = 1; i < Omas.Length; i++)
            {
                if (Omas[i] < minElement)
                {
                    minElement = Omas[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Минимальный элемент:{ minElement}");
            Console.WriteLine($"Индекс минимального элемента:{minIndex}");
            Console.ReadLine();
        }
    }
}
