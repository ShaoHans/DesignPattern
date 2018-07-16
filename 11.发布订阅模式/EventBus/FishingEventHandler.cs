using _11.发布订阅模式.EventBus.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式.EventBus
{
    public class FishingEventHandler : IEventHandler<FishingEventData>
    {
        public void HandleEvent(FishingEventData eventData)
        {
            eventData.FishingMan.FishCount++;
            Console.WriteLine($"{eventData.FishingMan.Name}：钓到一条{eventData.FishType}，共钓到{eventData.FishingMan.FishCount}条鱼！");
        }
    }
}
