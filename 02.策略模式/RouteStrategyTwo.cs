using System;
using System.Collections.Generic;
using System.Text;

namespace _02.策略模式
{
    public class RouteStrategyTwo: TrafficRouteStrategy
    {
        public override void ShowRoute()
        {
            Console.WriteLine("步行至1号线人民公园地铁站2出口，乘坐地铁1号线至域山站，换乘8号线至广兰路站下车，步行500米即到目的地！");
        }
    }
}
