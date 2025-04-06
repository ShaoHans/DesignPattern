using System;

namespace _12.抽象工厂模式
{
    public class NvidiaCpu : ICpu
    {
        public void Work()
        {
            Console.WriteLine("英伟达CPU开始工作啦。。。");
        }
    }
}
