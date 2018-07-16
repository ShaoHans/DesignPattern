using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _11.发布订阅模式.EventBus.Infrastructure
{
    public class EventBus
    {
        public static EventBus Default => new EventBus();

        private readonly ConcurrentDictionary<Type, List<Type>> _eventAndHandlerMappings;

        public EventBus()
        {
            _eventAndHandlerMappings = new ConcurrentDictionary<Type, List<Type>>();
            MapEventToHandler();
        }

        /// <summary>
        /// 通过反射，将事件源与事件处理绑定
        /// </summary>
        private void MapEventToHandler()
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            foreach (var handlerType in assembly.GetTypes().Where(t => typeof(IEventHandler).IsAssignableFrom(t)))
            {
                Type handlerInterface = handlerType.GetInterface("IEventHandler`1");
                if(handlerInterface == null)
                {
                    continue;
                }

                Type eventDataType = handlerInterface.GetGenericArguments()[0];
                if(_eventAndHandlerMappings.ContainsKey(eventDataType))
                {
                    List<Type> handlerTypes = _eventAndHandlerMappings[eventDataType];
                    handlerTypes.Add(handlerType);
                    _eventAndHandlerMappings[eventDataType] = handlerTypes;
                }
                else
                {
                    List<Type> handlerTypes = new List<Type> { handlerType };
                    _eventAndHandlerMappings[eventDataType] = handlerTypes;
                }
            }
        }

        /// <summary>
        /// 手动绑定事件源与事件处理
        /// </summary>
        /// <typeparam name="TEventData"></typeparam>
        /// <param name="eventHandler"></param>
        public void Register<TEventData>(Type eventHandler)
        {
            List<Type> handlerTypes = _eventAndHandlerMappings[typeof(TEventData)];
            if (handlerTypes != null && !handlerTypes.Contains(eventHandler))
            {
                handlerTypes.Add(eventHandler);
                _eventAndHandlerMappings[typeof(TEventData)] = handlerTypes;
            }
        }

        /// <summary>
        /// 手动解除事件源与事件处理的绑定
        /// </summary>
        /// <typeparam name="TEventData"></typeparam>
        /// <param name="eventHandler"></param>
        public void UnRegister<TEventData>(Type eventHandler)
        {
            List<Type> handlerTypes = _eventAndHandlerMappings[typeof(TEventData)];
            if (handlerTypes != null && handlerTypes.Contains(eventHandler))
            {
                handlerTypes.Remove(eventHandler);
                _eventAndHandlerMappings[typeof(TEventData)] = handlerTypes;
            }
        }

        /// <summary>
        /// 根据事件源触发绑定的事件处理
        /// </summary>
        /// <typeparam name="TEventData"></typeparam>
        /// <param name="eventData"></param>
        public void Trigger<TEventData>(TEventData eventData) where TEventData : IEventData
        {
            List<Type> handlerTypes = _eventAndHandlerMappings[eventData.GetType()];
            if (handlerTypes != null && handlerTypes.Count > 0)
            {
                foreach (var handlerType in handlerTypes)
                {
                    MethodInfo methodInfo = handlerType.GetMethod("HandleEvent");
                    if (methodInfo != null)
                    {
                        object obj = Activator.CreateInstance(handlerType);
                        methodInfo.Invoke(obj, new object[] { eventData });
                    }
                }
            }
        }
    }
}
