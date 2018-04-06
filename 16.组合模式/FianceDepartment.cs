using System;
using System.Collections.Generic;
using System.Text;

namespace _16.组合模式
{
    public class FianceDepartment : Company
    {
        public FianceDepartment(string name):base(name)
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
            Console.WriteLine($"{Name}计算员工绩效，发放工资...");
        }

        public override void Remove(Company company)
        {
        }
    }
}
