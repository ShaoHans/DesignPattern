using System;

namespace _04.代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.DoSomething();
            Console.ReadKey();
        }
    }
}
