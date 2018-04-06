using System;
using System.Collections.Generic;
using System.Text;

namespace _16.组合模式
{
    public abstract class Company
    {
        public string Name { get; protected set; }

        public Company(string name)
        {
            Name = name;
        }

        public abstract void Add(Company company);
        public abstract void Remove(Company company);
        public abstract void Display(int level);
        public abstract void LineOfDuty();// 履行职责
    }
}
