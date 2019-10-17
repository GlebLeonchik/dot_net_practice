using System;




namespace lecture10
{
    interface ISquardR
    {
        void Squard(int radius);
    }

    class Round : ISquardR
    {
        double SquardR;
        public void Squard(int radius)
        {
            SquardR=Math.PI*radius*radius;
        }
    }

    interface ISquardP
    {
        void Squard(int a);
    }

    class Box : ISquardP
    {
        int SquardP;
        public void Squard(int a)
        {
            SquardP = a * a; 
        }
    }

    interface ISquard

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
