using System;
using System.Collections.Generic;
using System.Text;

namespace _24.享元模式
{
    public class WeiQiZiFactory
    {
        private static Dictionary<int, WeiQiZi> _weiQiZiDict = new Dictionary<int, WeiQiZi>();
        private static readonly WeiQiZiFactory _factory = new WeiQiZiFactory();

        private WeiQiZiFactory()
        {
            _weiQiZiDict.Add(0, new BlackWeiQiZi());
            _weiQiZiDict.Add(1, new WhiteWeiQiZi());
        }

        public static WeiQiZiFactory GetInstance()
        {
            return _factory;
        }

        public WeiQiZi CreateWeiQiZi(int type)
        {
            if(_weiQiZiDict.ContainsKey(type))
            {
                return _weiQiZiDict[type];
            }
            return null;
        }
    }
}
