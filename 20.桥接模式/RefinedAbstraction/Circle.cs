using System;
using System.Collections.Generic;
using System.Text;

namespace _20.桥接模式
{
    public class Circle : MyShape
    {
        public override void Draw()
        {
            _color.Paint("圆形");
        }
    }
}
