using System;

namespace _20.桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MyShape circle = new Circle();
            circle.SetColor(new Red());
            circle.Draw();

            MyShape square = new Square();
            square.SetColor(new Green());
            square.Draw();

            Console.ReadKey();
        }
    }
}
