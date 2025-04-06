using System;

namespace _01.简单工厂模式;

public class MobileFactory
{
    public static Mobile Create(MobileType type)
    {
        switch (type)
        {
            case MobileType.IPhone:
                return new IPhone();

            case MobileType.Nokia:
                return new Nokia();

            case MobileType.XiaoMi:
                return new XiaoMi();
            default:
                throw new Exception("未知的手机品牌类别");
        }
    }
}

public enum MobileType
{
    IPhone = 1,
    Nokia = 2,
    XiaoMi = 3
}
