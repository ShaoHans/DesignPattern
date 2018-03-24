using System;

namespace _01.简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入你要制造的手机品牌，1：苹果，2：诺基亚，3：小米");
            var strType = Console.ReadLine();
            if(int.TryParse(strType, out int mobileType))
            {
                Mobile mobile = MobileFactory.Create((MobileType)mobileType);
                mobile.Show();
            }
            Console.ReadKey();
        }
    }
}
