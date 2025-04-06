namespace _10.观察者模式
{
    public interface ISubject
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Nodify();
    }
}
