using System;

namespace _03.装饰模式
{
    public class StarbucksCoffee : Coffee
    {
        public override void Make()
        {
            Console.WriteLine("正在制作星巴克咖啡...");
        }
    }
}
