using System;

namespace _22.职责链模式
{
    /// <summary>
    /// 组长
    /// </summary>
    public class ZuZhang : Handler
    {
        public ZuZhang(string name) : base(name)
        {

        }

        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"组长【{Name}】同意【{request.Amount}】的采购申请。");
            }
            else
            {
                Console.WriteLine($"组长【{Name}】无法处理【{request.Amount}】的采购申请，转给上级【{Superior.Name}】处理。");
                Superior.HandleRequest(request);
            }
        }
    }
}
