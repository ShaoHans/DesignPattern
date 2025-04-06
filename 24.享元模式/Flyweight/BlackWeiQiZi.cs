using System;
using System.Drawing;

namespace _24.享元模式
{
    public class BlackWeiQiZi : WeiQiZi
    {
        public BlackWeiQiZi()
        {
            Color = "黑色";
        }

        public override void Display(Point point)
        {
            Console.WriteLine($"我是{Color}棋子，当前坐标：{point.X},{point.Y}");
        }
    }
}
