using System; 
interface ICalc
    {
         void Calc();
    }
class Square : ICalc
    {
        string txt = "Square";
        double[] square = new double[10];
        public void Calc()
        {
        for (int i = 0; i < square.Length; i++)
        {
            int x = i + 1;
            square[i] = Math.Pow(x,2);
            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}.", txt, GetType(), square[i]);
            }
           
        }
    }

class Circle : ICalc
{
    string txt = "Circle";
    double[] circle = new double[10];
    public void Calc()
    {
        for(int i = 0; i < circle.Length; i++)
        {
            int x = i + 1;
            circle[i] = Math.PI * Math.Pow(x, 2);
            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}.", txt, GetType(),Math.Round(circle[i],2));
        }
    }
}

class Triangle : ICalc
{
    string txt = "Triangle";
    int[] triangle = new int[10];
    public void Calc()
    {
        for(int i = 0; i < triangle.Length; i++)
        {
            int x = i + 1;
            triangle[i] = (x * x) / 2;
            Console.WriteLine("This is {0}. CLR Type is {1}. Square is {2}.", txt, GetType(), triangle[i]);
        }
    }
}
namespace lecture10
{      
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            square.Calc();
            Console.WriteLine();
            circle.Calc();
            Console.WriteLine();
            triangle.Calc();
            Console.ReadKey();
        }
    }
}
