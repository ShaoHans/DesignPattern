using System;

namespace _19.单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            LanHanSingleton lanhan1 = LanHanSingleton.GetInstance();
            LanHanSingleton lanhan2 = LanHanSingleton.GetInstance();
            Console.WriteLine(lanhan1.GetHashCode() == lanhan2.GetHashCode());

            EHanSingleton ehan1 = EHanSingleton.GetInstance();
            EHanSingleton ehan2 = EHanSingleton.GetInstance();
            Console.WriteLine(ehan1.GetHashCode() == ehan2.GetHashCode());

            Console.ReadKey();
        }
    }
}
