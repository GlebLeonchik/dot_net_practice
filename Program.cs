using System;

namespace Practic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива:");
            Random rdn = new Random();
            int[] mass = new int[6];
            for(int i = 0; i < mass.Length; i++)
            {
                mass[i] = rdn.Next(1,101);
            }
            Console.WriteLine();
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            mass[2] *= 10;
            Console.WriteLine();
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
           
            
        }
    }
}
