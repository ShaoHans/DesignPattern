using System;

namespace _05.工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobileFactory factory = new IPhoneFactory();
            Mobile iphone = factory.Create();
            iphone.Show();
            Console.ReadKey();
        }
    }
}
