using System;
using System.Collections.Generic;
using System.Text;

namespace _12.抽象工厂模式
{
    public class LenovoComputeFactory : IComputeFactory
    {
        public ICpu CreateCpu()
        {
            return new NvidiaCpu();
        }

        public IMainBoard CreateMainBoard()
        {
            return new AsusMainBoard();
        }
    }
}
