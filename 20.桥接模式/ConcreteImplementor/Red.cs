using System;

namespace _20.桥接模式
{
    public class Red : MyColor
    {
        public override void Paint(string shape)
        {
            Console.WriteLine($"画红色的{shape}");
        }
    }
}
