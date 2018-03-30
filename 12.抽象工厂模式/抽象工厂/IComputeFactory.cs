using System;
using System.Collections.Generic;
using System.Text;

namespace _12.抽象工厂模式
{
    public interface IComputeFactory
    {
        ICpu CreateCpu();
        IMainBoard CreateMainBoard();
    }
}
