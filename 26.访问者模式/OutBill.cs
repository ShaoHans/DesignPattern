using System;
using System.Collections.Generic;
using System.Text;

namespace _26.访问者模式
{
    /// <summary>
    /// 支出账单
    /// </summary>
    public class OutBill : Bill
    {
        public override void Accept(Visitor visitor)
        {
            visitor.CalcTotalOutAmount(this);
        }
    }
}
