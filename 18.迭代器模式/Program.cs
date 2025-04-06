using System;

namespace _18.迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate list = new ConcreteAggregate();
            list[0] = "张三";
            list[1] = "李四";
            list[2] = "王五";
            list[3] = "马六";
            list[4] = "骨七";

            Iterator iterator = list.GetIterator();

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
