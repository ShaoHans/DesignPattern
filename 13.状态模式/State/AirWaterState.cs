using System;

namespace _13.状态模式
{
    public class AirWaterState : WaterState
    {
        public override void Show()
        {
            Console.WriteLine($"当前温度是{Degree}°，我变成气体了~~~");
        }
    }
}
