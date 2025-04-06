using System;

namespace _11.发布订阅模式.EventBus.Infrastructure
{
    public class EventData : IEventData
    {
        public DateTime EventTime { get; set; }
        public object EventSource { get; set; }

        public EventData()
        {
            EventTime = DateTime.Now;
        }
    }
}
