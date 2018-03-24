using System;
using System.Collections.Generic;
using System.Text;

namespace _01.简单工厂模式
{
    public class XiaoMi: Mobile
    {
        public override void Show()
        {
            Console.WriteLine($"我是【{Brand}】手机，中国的后起新秀，正在逐渐扩大海外市场....");
        }
    }
}
