using System;
using System.Collections.Generic;
using System.Text;

namespace _05.工厂方法模式
{
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
}
