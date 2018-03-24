using System;
using System.Collections.Generic;
using System.Text;

namespace _02.策略模式
{
    public class RouteStrategyOne: TrafficRouteStrategy
    {
        public override void ShowRoute()
        {
            Console.WriteLine("步行至1号线人民公园地铁站2出口，乘坐地铁1号线至宝山站，从3号出口出站，步行300米到达香蜜湖公交站，乘坐300路公交在华侨城站下车，步行300米即到目的地！");
        }
    }
}
