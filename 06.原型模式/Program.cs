using System;

namespace _06.原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume();
            r1.SetWorkExperience("Tencent", 2011);
            Resume r2 = (Resume)r1.Clone();
            r2.SetWorkExperience("Alipay", 2016);

            r1.Show();
            r2.Show();
            Console.ReadKey();
        }
    }
}
