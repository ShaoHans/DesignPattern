using System;

namespace _22.职责链模式
{
    /// <summary>
    /// 总经理
    /// </summary>
    public class ZongJingLi : Handler
    {
        public ZongJingLi(string name) : base(name)
        {

        }

        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount > 10000 && request.Amount <= 50000)
            {
                Console.WriteLine($"总经理【{Name}】同意【{request.Amount}】的采购申请。");
            }
            else
            {
                Console.WriteLine("金额太大，需要经过会议讨论再做决定");
            }
        }
    }
}
