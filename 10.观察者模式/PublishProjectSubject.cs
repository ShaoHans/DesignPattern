using System.Collections.Generic;

namespace _10.观察者模式
{
    public class PublishProjectSubject : ISubject
    {
        private IList<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Nodify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
