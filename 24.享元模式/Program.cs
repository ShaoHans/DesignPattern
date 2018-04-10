using System;
using System.Drawing;

namespace _24.享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WeiQiZiFactory factory = WeiQiZiFactory.GetInstance();
            WeiQiZi black1, black2, black3, white1, white2;
            black1 = factory.CreateWeiQiZi(0);
            black2 = factory.CreateWeiQiZi(0);
            black3 = factory.CreateWeiQiZi(0);
            white1 = factory.CreateWeiQiZi(1);
            white2 = factory.CreateWeiQiZi(1);

            Console.WriteLine(black1 == black2);
            Console.WriteLine(white1 == white2);
            Console.WriteLine(black3 == white1);

            black1.Display(new Point(1, 2));
            black2.Display(new Point(1, 3));
            black3.Display(new Point(1, 4));
            white1.Display(new Point(1, 5));
            white2.Display(new Point(1, 6));

            Console.WriteLine(black1 == black2);
            Console.WriteLine(white1 == white2);
            Console.WriteLine(black3 == white1);

            Console.ReadKey();
        }
    }
}
