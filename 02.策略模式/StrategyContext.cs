using System;

namespace _02.策略模式
{
    public class StrategyContext
    {
        private TrafficRouteStrategy _strategy;
        public StrategyContext(StrategyType type)
        {
            switch (type)
            {
                case StrategyType.One:
                    _strategy = new RouteStrategyOne();
                    break;
                case StrategyType.Two:
                    _strategy = new RouteStrategyTwo();
                    break;
                case StrategyType.Three:
                    _strategy = new RouteStrategyThree();
                    break;
                default:
                    throw new Exception("未知的交通线路方案");
            }
        }

        public void ShowRoute()
        {
            _strategy.ShowRoute();
        }
    }

    public enum StrategyType
    {
        One = 1,
        Two = 2,
        Three = 3
    }
}
