using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);
            if (time > 9 && time < 12)
            {
                Console.WriteLine("Good morning,guys");
            }
            else if (time > 12 && time < 15)
            {
                Console.WriteLine("Good day,guys");
            }
            else if (time > 15 && time < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else 
            {
                Console.WriteLine("Good night, guys");
            }
        }
    }
}
