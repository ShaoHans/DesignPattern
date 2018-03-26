using System;

namespace _07.模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学生A的测试情况：");
            TestPaper a = new StudentATest();
            a.Question1();
            a.Question2();

            Console.WriteLine("学生B的测试情况：");
            TestPaper b = new StudentBTest();
            b.Question1();
            b.Question2();

            Console.ReadKey();
        }
    }
}
