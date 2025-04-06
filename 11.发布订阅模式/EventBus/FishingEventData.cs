using _11.发布订阅模式.EventBus.Infrastructure;

namespace _11.发布订阅模式.EventBus
{
    public class FishingEventData : EventData
    {
        public FishType FishType { get; set; }

        public FishingMan FishingMan { get; set; }
    }
}
