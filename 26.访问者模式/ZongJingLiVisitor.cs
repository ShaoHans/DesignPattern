using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _26.访问者模式
{
    public class ZongJingLiVisitor : Visitor
    {
        public override void CalcTotalInAmount(Bill bill)
        {
            Console.WriteLine($"总经理查看公司所有账单的总收入：{bill._items.Where(a => a.Type == 0).Sum(a => a.Amount)}元");
        }

        public override void CalcTotalOutAmount(Bill bill)
        {
            Console.WriteLine($"总经理查看公司所有账单的总支出：{bill._items.Where(a => a.Type == 1).Sum(a => a.Amount)}元");
        }
    }
}
