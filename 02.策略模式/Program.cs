using _02.策略模式.Sort;
using System;

namespace _02.策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("选择你的出行交通线路，1：步行少，2：时间快，3：风景好");
            //string strType = Console.ReadLine();
            //if(int.TryParse(strType,out int type))
            //{
            //    StrategyContext context = new StrategyContext((StrategyType)type);
            //    context.ShowRoute();
            //}

            Cat[] arr = new Cat[] { new Cat(2, 1), new Cat(5, 5), new Cat(6, 3) };
            Sorter<Cat> sorter = new Sorter<Cat>();

            Console.WriteLine("按高度排序...");
            sorter.Sort(arr, new CatHeightComparer());
            foreach (var c in arr)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("按重量排序...");
            sorter.Sort(arr, new CatWeightComparer());
            foreach (var c in arr)
            {
                Console.WriteLine(c.ToString());
            }


            Console.ReadKey();
        }
    }
}
