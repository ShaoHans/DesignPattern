using System;

namespace _14.适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoggerTarget logger = new LoggerTarget();
            LoggerTarget logger = new LoggerAdapter();
            logger.Info();
            Console.ReadKey();
        }
    }
}
