using System;
using System.Collections.Generic;
using System.Text;

namespace _19.单例模式
{
    /// <summary>
    /// 饿汉式单例类
    /// </summary>
    public sealed class EHanSingleton
    {
        private static readonly EHanSingleton singleton = new EHanSingleton();

        private EHanSingleton()
        {

        }

        public static EHanSingleton GetInstance()
        {
            return singleton;
        }
    }
}
