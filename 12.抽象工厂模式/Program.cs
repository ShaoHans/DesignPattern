using System;

namespace _12.抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {

            IComputeFactory dellCompute = new DellComputeFactory();
            dellCompute.CreateCpu().Work();
            dellCompute.CreateMainBoard().Work();

            IComputeFactory lenovoCompute = new LenovoComputeFactory();
            lenovoCompute.CreateCpu().Work();
            lenovoCompute.CreateMainBoard().Work();

            Console.ReadKey();
        }
    }
}
