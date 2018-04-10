using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26.访问者模式
{
    public class ITDepartmentLeaderVisitor : Visitor
    {
        public override void CalcTotalInAmount(Bill bill)
        {
            Console.WriteLine($"IT部门经理查看本部门所有账单的总收入：{bill._items.Where(a => a.Type == 0 && a.Department == "IT部门").Sum(a => a.Amount)}元");
        }

        public override void CalcTotalOutAmount(Bill bill)
        {
            Console.WriteLine($"IT部门经理查看本部门所有账单的总支出：{bill._items.Where(a => a.Type == 1 && a.Department == "IT部门").Sum(a => a.Amount)}元");
        }
    }
}
