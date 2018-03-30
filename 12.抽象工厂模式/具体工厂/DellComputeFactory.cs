using System;
using System.Collections.Generic;
using System.Text;

namespace _12.抽象工厂模式
{
    public class DellComputeFactory : IComputeFactory
    {
        public ICpu CreateCpu()
        {
            return new InterCpu();
        }

        public IMainBoard CreateMainBoard()
        {
            return new GigabyteMainBoard();
        }
    }
}
