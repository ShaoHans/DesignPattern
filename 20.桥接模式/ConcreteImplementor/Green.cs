using System;

namespace _20.桥接模式
{
    public class Green : MyColor
    {
        public override void Paint(string shape)
        {
            Console.WriteLine($"画绿色的{shape}");
        }
    }
}
