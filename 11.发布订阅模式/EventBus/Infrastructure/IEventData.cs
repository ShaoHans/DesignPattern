using System;

namespace _11.发布订阅模式.EventBus.Infrastructure
{
    /// <summary>
    /// 定义事件源接口，所有的事件源都要实现该接口
    /// </summary>
    public interface IEventData
    {
        /// <summary>
        /// 事件发生时间
        /// </summary>
        DateTime EventTime { get; set; }

        /// <summary>
        /// 触发事件的对象
        /// </summary>
        object EventSource { get; set; }
    }
}
