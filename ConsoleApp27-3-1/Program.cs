using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Omas = { 10, 5, 20, 8, 25, 15 };          
            int maxElement = Omas[0];
            int maxIndex = 0;

            for (int i = 1; i < Omas.Length; i++)
            {
                if (Omas[i] > maxElement)
                {
                    maxElement = Omas[i];
                    maxIndex = i;
                }
            }  
            Console.WriteLine($"Максимальный элемент:{maxElement}");
            Console.WriteLine($"Индекс максимального элемента:{maxIndex}");
            Console.ReadLine();
        }
    }
}
