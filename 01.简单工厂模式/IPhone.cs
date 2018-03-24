using System;
using System.Collections.Generic;
using System.Text;

namespace _01.简单工厂模式
{
    public class IPhone: Mobile
    {
        public IPhone() 
        {
            Brand = "苹果";
        }

        public override void Show()
        {
            Console.WriteLine($"我是【{Brand}】手机，我的发明者是乔大爷，我是世界上最炫酷的手机！");
        }
    }
}
