using System;
using System.Collections.Generic;
using System.Text;

namespace _03.装饰模式
{
    public abstract class Decorator: Coffee
    {
        private Coffee _coffee;

        public Decorator(Coffee coffee)
        {
            _coffee = coffee;
        }


        public override void Make()
        {
            if (_coffee != null)
            {
                _coffee.Make();
            }
        }
    }
}
