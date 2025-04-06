using System;
using System.Collections.Generic;

namespace _16.组合模式
{
    public class ConcreteCompany : Company
    {
        private List<Company> _children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {

        }

        public override void Add(Company company)
        {
            _children.Add(company);
        }

        public override void Display(int level)
        {
            Console.WriteLine(new String('-', level) + Name);
            foreach (var child in _children)
            {
                child.Display(level + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var child in _children)
            {
                child.LineOfDuty();
            }
        }

        public override void Remove(Company company)
        {
            _children.Remove(company);
        }
    }
}
