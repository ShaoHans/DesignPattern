using System;
using System.Collections.Generic;
using System.Text;

namespace _14.适配器模式
{
    public class NLogAdaptee
    {
        public void WriteInfoLog()
        {
            Console.WriteLine("NLog框架记录Info日志");
        }
    }
}
