using System;

namespace _14.适配器模式
{
    public class LoggerTarget
    {
        public virtual void Info()
        {
            Console.WriteLine("自定义框架写日志");
        }
    }
}
