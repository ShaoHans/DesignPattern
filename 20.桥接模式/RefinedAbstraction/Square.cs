﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _20.桥接模式
{
    public class Square : MyShape
    {
        public override void Draw()
        {
            _color.Paint("正方形");
        }
    }
}
