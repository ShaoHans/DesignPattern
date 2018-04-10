using System;
using System.Collections.Generic;
using System.Text;

namespace _26.访问者模式
{
    /// <summary>
    /// 收入账单
    /// </summary>
    public class InBill : Bill
    {
        public override void Accept(Visitor visitor)
        {
            visitor.CalcTotalInAmount(this);
        }
    }
}
