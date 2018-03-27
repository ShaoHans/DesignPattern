using System;

namespace _08.外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("用户提交了购物车商品!");
            ShoppingCarFacade facade = new ShoppingCarFacade();
            facade.Submit();

            Console.ReadKey();
        }
    }
}
