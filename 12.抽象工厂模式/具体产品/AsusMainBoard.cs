using System;

namespace _12.抽象工厂模式
{
    public class AsusMainBoard : IMainBoard
    {
        public void Work()
        {
            Console.WriteLine("华硕主板开始工作了。。。");
        }
    }
}
