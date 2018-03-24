using System;
using System.Collections.Generic;
using System.Text;

namespace _03.装饰模式
{
    public class MilkDecorator: Decorator
    {
        public MilkDecorator(Coffee coffee):base(coffee)
        {

        }

        public override void Make()
        {
            base.Make();
            Console.WriteLine("加牛奶...");
        }
    }
}
