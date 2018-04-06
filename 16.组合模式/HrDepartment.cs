using System;
using System.Collections.Generic;
using System.Text;

namespace _16.组合模式
{
    public class HrDepartment : Company
    {
        public HrDepartment(string name):base(name)
        {

        }

        public override void Add(Company company)
        {
        }

        public override void Display(int level)
        {
            Console.WriteLine(new String('-', level) + Name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{Name}制定公司制度，招募人才...");
        }

        public override void Remove(Company company)
        {
        }
    }
}
