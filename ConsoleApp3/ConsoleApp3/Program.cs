using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic txt = ", guys!";
            dynamic[] array = { 32, 'A', "Hello" };
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" ");
            }
            Console.WriteLine();
            array[0] =array[0]+10;
            array[2] = array[2] + txt;
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" ");
            }
        }
       
    }
}
