﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式
{
    public class EmailObserver
    {
        public void SendEmail()
        {
            Console.WriteLine("有新项目发布了，给用户发送邮件通知...");            
        }

    }
}
