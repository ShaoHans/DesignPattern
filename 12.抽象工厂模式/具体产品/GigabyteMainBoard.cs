using System;

namespace _12.抽象工厂模式
{
    public class GigabyteMainBoard : IMainBoard
    {
        public void Work()
        {
            Console.WriteLine("技嘉主板开始工作了。。。");
        }
    }
}
