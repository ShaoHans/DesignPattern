using System;

namespace _01.简单工厂模式;

/// <summary>
/// 手机抽象类
/// </summary>
public abstract class Mobile
{
    /// <summary>
    /// 品牌名称
    /// </summary>
    public string Brand { get; protected set; }

    /// <summary>
    /// 手机展示
    /// </summary>
    public virtual void Show() => Console.WriteLine($"我是【{Brand}】品牌手机");
}
