using _11.发布订阅模式.EventBus.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式.EventBus
{
    public class FishingEventData: EventData
    {
        public FishType FishType { get; set; }

        public FishingMan FishingMan { get; set; }
    }
}
