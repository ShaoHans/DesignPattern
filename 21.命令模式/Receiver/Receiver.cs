using System;

namespace _21.命令模式
{
    /// <summary>
    /// 命令接收者（处理命令）
    /// </summary>
    public abstract class Receiver
    {
        public virtual void Action()
        {
            Console.WriteLine("命令被执行了");
        }
    }
}
