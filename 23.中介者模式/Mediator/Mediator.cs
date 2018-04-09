using System;
using System.Collections.Generic;
using System.Text;

namespace _23.中介者模式
{
    /// <summary>
    /// 中介者抽象类
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Change(Colleague colleague);
    }
}
