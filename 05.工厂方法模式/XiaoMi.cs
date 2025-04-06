using System;

namespace _05.工厂方法模式
{
    public class XiaoMi : Mobile
    {
        public override void Show()
        {
            Console.WriteLine($"我是【{Brand}】手机，中国的后起新秀，正在逐渐扩大海外市场....");
        }
    }
}
