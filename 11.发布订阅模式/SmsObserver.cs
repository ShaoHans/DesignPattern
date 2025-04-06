using System;

namespace _11.发布订阅模式
{
    public class SmsObserver
    {
        public void SendSms()
        {
            Console.WriteLine("有新项目发布了，给用户发送短信通知...");
        }
    }
}
