using _11.发布订阅模式.EventBus.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式.EventBus
{
    /// <summary>
    /// 垂钓者（观察者）
    /// </summary>
    public class FishingMan//: IEventHandler<FishingEventData>
    {
        public string Name { get; private set; }

        public int FishCount { get; set; }

        /// <summary>
        /// 垂钓者鱼竿
        /// </summary>
        public FishingRod FishingRod { get; set; }

        public FishingMan(string name)
        {
            Name = name;
        }

        public void Fishing()
        {
            FishingRod.ThrowHook(this);
        }

        //public void HandleEvent(FishingEventData eventData)
        //{
        //    FishCount++;
        //    Console.WriteLine($"{Name}：钓到一条{eventData.FishType}，共钓到{FishCount}条鱼！");
        //}
    }
}
