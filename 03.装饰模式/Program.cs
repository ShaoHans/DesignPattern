using System;

namespace _03.装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            StarbucksCoffee coffee = new StarbucksCoffee();
            MilkDecorator milk = new MilkDecorator(coffee);
            SugarDecorator sugar = new SugarDecorator(milk);
            sugar.Make();

            Console.ReadKey();
        }
    }
}
