using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _24.享元模式
{
    public class WhiteWeiQiZi : WeiQiZi
    {
        public WhiteWeiQiZi()
        {
            Color = "白色";
        }

        public override void Display(Point point)
        {
            Console.WriteLine($"我是{Color}棋子，当前坐标：{point.X},{point.Y}");
        }
    }
}
