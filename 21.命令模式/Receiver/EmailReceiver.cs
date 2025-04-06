using System;

namespace _21.命令模式
{
    public class EmailReceiver : Receiver
    {
        public override void Action()
        {
            Console.WriteLine("发送邮件成功");
        }
    }
}
