using System;
using System.Collections.Generic;
using System.Text;

namespace _26.访问者模式
{
    public class ObjectStructure
    {
        private List<Bill> bills = new List<Bill>();

        public void Add(Bill bill)
        {
            bills.Add(bill);
        }

        public void Show(Visitor visitor)
        {
            foreach (var bill in bills)
            {
                bill.Accept(visitor);
            }
        }
    }
}
