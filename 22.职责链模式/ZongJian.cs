using System;
using System.Collections.Generic;
using System.Text;

namespace _22.职责链模式
{
    /// <summary>
    /// 总监
    /// </summary>
    public class ZongJian : Handler
    {
        public ZongJian(string name) : base(name)
        {

        }

        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount > 1000 && request.Amount <= 10000)
            {
                Console.WriteLine($"总监【{Name}】同意【{request.Amount}】的采购申请。");
            }
            else
            {
                Console.WriteLine($"总监【{Name}】无法处理【{request.Amount}】的采购申请，转给上级【{Superior.Name}】处理。");
                Superior.HandleRequest(request);
            }
        }
    }
}
