using System;

namespace _22.职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseRequest request = new PurchaseRequest { Amount = 20000 };
            Handler zuzhang = new ZuZhang("张三");
            Handler zongjian = new ZongJian("李四");
            Handler zongjingli = new ZongJingLi("王五");

            zuzhang.Next(zongjian);
            zongjian.Next(zongjingli);

            zuzhang.HandleRequest(request);

            Console.ReadKey();
        }
    }
}
