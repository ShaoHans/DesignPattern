using System;

namespace _02.策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择你的出行交通线路，1：步行少，2：时间快，3：风景好");
            string strType = Console.ReadLine();
            if(int.TryParse(strType,out int type))
            {
                StrategyContext context = new StrategyContext((StrategyType)type);
                context.ShowRoute();
            }
            Console.ReadKey();
        }
    }
}
