using _22.职责链模式.Cor;

using System;

namespace _22.职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PurchaseRequest request = new PurchaseRequest { Amount = 20000 };
            Handler zuzhang = new ZuZhang("张三");
            Handler zongjian = new ZongJian("李四");
            Handler zongjingli = new ZongJingLi("王五");

            zuzhang.Next(zongjian);
            zongjian.Next(zongjingli);

            zuzhang.HandleRequest(request);
            */

            Request request = new Request();
            Response response = new Response();
            var chain = new FilterChain();
            chain.Add(new ActionExecutingFilter()).Add(new ActionExecutedFilter()).Add(new ExceptionFilter());
            chain.DoFilter(request, response);
            Console.WriteLine(request.Header);
            Console.WriteLine(response.Data);

            Console.ReadKey();
        }
    }
}
