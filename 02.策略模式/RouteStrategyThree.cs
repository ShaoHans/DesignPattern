using System;
using System.Collections.Generic;
using System.Text;

namespace _02.策略模式
{
    public class RouteStrategyThree: TrafficRouteStrategy
    {
        public override void ShowRoute()
        {
            Console.WriteLine("步行200米至花山公交站，乘坐112/234/567路公交至尼康公交站下车，步行400米即到目的地！");
        }
    }
}
