﻿using System;

namespace _05.工厂方法模式
{
    public class Nokia : Mobile
    {
        public override void Show()
        {
            Console.WriteLine($"我是【{Brand}】手机，手机中的战斗机，砸不烂摔不破，我渐渐的落寞了...");
        }
    }
}
