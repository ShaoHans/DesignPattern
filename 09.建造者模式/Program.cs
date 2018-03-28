using System;

namespace _09.建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("开始生产宝马车...");
            BaoMaBuilder baoMaBuilder = new BaoMaBuilder();
            Director director = new Director(baoMaBuilder);
            director.Create();
            Car baoMaCar = baoMaBuilder.GetResult();
            Console.WriteLine(baoMaCar.ToString());

            Console.WriteLine("开始生产奔驰车...");
            BenChiBuilder benChiBuilder = new BenChiBuilder();
            director = new Director(benChiBuilder);
            director.Create();
            Car benChiCar = benChiBuilder.GetResult();
            Console.WriteLine(benChiCar.ToString());

            Console.ReadKey();
        }
    }
}
