using System;

namespace _12.抽象工厂模式
{
    public class InterCpu : ICpu
    {
        public void Work()
        {
            Console.WriteLine("英特尔CPU开始工作啦。。。");
        }
    }
}
