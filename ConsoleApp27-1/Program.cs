using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");

            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                omas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = omas.Length; i >= 0; i--)
            {
                Console.Write(omas[i] + " ");
            }
           
            Console.ReadKey();
        }
        static public void Outputreverse(int[] array)
        {
            int[] reversedArray = (int[])array.Clone();
            Array.Reverse(reversedArray);

            foreach (int element in reversedArray)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}

