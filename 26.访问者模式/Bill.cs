using System;
using System.Collections.Generic;
using System.Text;

namespace _26.访问者模式
{
    public abstract class Bill
    {
        public List<BillItem> _items = new List<BillItem>();

        public Bill()
        {
            _items.Add(new BillItem { Name = "购买办公用品", Department = "财务部门", Amount = 3450, Type = 1 });
            _items.Add(new BillItem { Name = "年度旅游", Department = "财务部门", Amount = 36985, Type = 1 });
            _items.Add(new BillItem { Name = "卖出产品", Department = "运营部门", Amount = 12433, Type = 0 });
            _items.Add(new BillItem { Name = "用户投放广告", Department = "IT部门", Amount = 2344, Type = 0 });
            _items.Add(new BillItem { Name = "用户投放广告", Department = "IT部门", Amount = 5423, Type = 0 });
            _items.Add(new BillItem { Name = "用户投放广告", Department = "IT部门", Amount = 123, Type = 0 });
            _items.Add(new BillItem { Name = "年度旅游", Department = "IT部门", Amount = 4212, Type = 1 });
        }

        public abstract void Accept(Visitor visitor);
    }


    public class BillItem
    {
        /// <summary>
        /// 账单条目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 账单条目所属部门
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 账单条目金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 账单条目类别（0：收入，1：支出）
        /// </summary>
        public int Type { get; set; }
    }
}
