using System;
using System.Collections.Generic;
using System.Text;

namespace _07.模板方法模式
{
    public class StudentBTest: TestPaper
    {
        public override string Answer1()
        {
            return "B";
        }

        public override string Answer2()
        {
            return "C";
        }
    }
}
