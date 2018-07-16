using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式.EventBus
{
    /// <summary>
    /// 鱼竿（被观察者）
    /// </summary>
    public class FishingRod
    {
        //public delegate void FishingHandler(FishingEventData eventData);
        //public event FishingHandler FishingEvent;

        public void ThrowHook(FishingMan fishingMan)
        {
            Console.WriteLine("开始下钩");

            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                //FishingEvent?.Invoke(new FishingEventData { FishType = type, FishingMan = fishingMan });
                EventBus.Infrastructure.EventBus.Default.Trigger<FishingEventData>(new FishingEventData { FishType = type, FishingMan = fishingMan });
            }
        }
    }
}
