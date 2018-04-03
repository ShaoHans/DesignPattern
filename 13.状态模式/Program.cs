using System;

namespace _13.状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterContext context = new WaterContext();
            context.ShowWaterState(-2);
            context.ShowWaterState(0);
            context.ShowWaterState(23);
            context.ShowWaterState(100);
            context.ShowWaterState(102);
            Console.ReadKey();
        }
    }
}
