using System;
using System.Collections.Generic;
using System.Text;

namespace _10.观察者模式
{
    public class EmailObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("有新项目发布了，给用户发送邮件通知...");
        }
    }
}
