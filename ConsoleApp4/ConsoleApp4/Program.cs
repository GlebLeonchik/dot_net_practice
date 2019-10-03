using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int max=0;
            int[] array= new int[13];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rdn.Next(1, 101);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine("Максимальный элемент:"+max);
        }
    }
}
