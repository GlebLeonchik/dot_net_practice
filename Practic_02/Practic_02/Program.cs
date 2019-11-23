using System;

namespace Practic_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char symb = 'a';
            int count = 0;
            Console.WriteLine("Введите слово:");
            string txt = Console.ReadLine();
            for(int i = 0; i < txt.Length;)
            {
                if (symb == txt[i])
                {
                    count++;
                    i++;
                }
                else
                    i++;
            }
            Console.WriteLine(count);
        }
    }
}
