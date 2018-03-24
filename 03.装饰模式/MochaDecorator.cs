using System;
using System.Collections.Generic;
using System.Text;

namespace _03.装饰模式
{
    public class MochaDecorator: Decorator
    {
        public MochaDecorator(Coffee coffee):base(coffee)
        {

        }

        public override void Make()
        {
            base.Make();
            Console.WriteLine("加摩卡...");
        }
    }
}
