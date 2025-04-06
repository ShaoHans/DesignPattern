using System;

namespace _10.观察者模式
{
    public class SmsObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("有新项目发布了，给用户发送短信通知...");
        }
    }
}
