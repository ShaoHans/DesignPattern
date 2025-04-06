using System;

namespace _07.模板方法模式
{
    public abstract class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("1. 1+1=? A:3,B:2,C:4,D:1");
            Console.WriteLine("答案：" + Answer1());
        }

        public virtual string Answer1()
        {
            return string.Empty;
        }

        public void Question2()
        {
            Console.WriteLine("2. 3*4=? A:7,B:3,C:4,D:12");
            Console.WriteLine("答案：" + Answer2());
        }

        public virtual string Answer2()
        {
            return string.Empty;
        }
    }
}
